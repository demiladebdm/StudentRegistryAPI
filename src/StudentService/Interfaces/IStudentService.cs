using StudentService.Models;

namespace StudentService.Interfaces
{
    public interface IStudentService
    {
        Task<Student> RegisterStudentAsync(Student student);
        Task<bool> VerifyOTPAsync(string phoneNumber, string otp);
        Task<IEnumerable<Student>> GetAllStudentsAsync();
    }
}
