using Microsoft.EntityFrameworkCore;
using NotificationService.Interfaces;
using StudentService.Data;
using StudentService.Interfaces;
using StudentService.Models;

namespace StudentService.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;
        private readonly IOTPGenerator _otpGenerator;
        private readonly IStateLGAValidator _stateLGAValidator;
        private readonly INotificationService _notificationService;

        private static readonly Dictionary<string, string> _otpStore = new();

        public StudentService(
            ApplicationDbContext context,
            IOTPGenerator otpGenerator,
            IStateLGAValidator stateLGAValidator,
            INotificationService notificationService)
        {
            _context = context;
            _otpGenerator = otpGenerator;
            _stateLGAValidator = stateLGAValidator;
            _notificationService = notificationService;
        }

        public async Task<Student> RegisterStudentAsync(Student student)
        {
            if (!_stateLGAValidator.Validate(student.State, student.LGA))
            {
                throw new ArgumentException("Invalid State-LGA combination");
            }

            var otp = _otpGenerator.GenerateOTP();
            _otpStore[student.PhoneNumber] = otp;

            var isOTPSent = await _notificationService.GenerateAndSendOTPAsync(student.PhoneNumber);

            if (isOTPSent == null)
            {
                throw new Exception("Failed to send OTP. Please try again.");
            }

            student.IsPhoneVerified = false; // Initially not verified
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<bool> VerifyOTPAsync(string phoneNumber, string otp)
        {
            if (!_notificationService.VerifyStoredOTP(phoneNumber, otp))
            {
                return false;
            }

            var student = await _context.Students.FirstOrDefaultAsync(s => s.PhoneNumber == phoneNumber);
            if (student == null)
            {
                return false;
            }

            student.IsPhoneVerified = true;
            await _context.SaveChangesAsync();

            _notificationService.ClearOTP(phoneNumber);
            return true;
        }


        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}