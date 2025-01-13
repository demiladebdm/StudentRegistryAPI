using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationService.Interfaces;
using NotificationService.Models;
using StudentService.DTOs;
using StudentService.Interfaces;
using StudentService.Models;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly INotificationService _notificationService;
        private IMapper _mapper;

        public StudentsController(IStudentService studentService, INotificationService notificationService, IMapper mapper)
        {
            _studentService = studentService;
            _notificationService = notificationService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterStudent([FromBody] StudentsDto studentModel)
        {
            Student student = _mapper.Map<Student>(studentModel);

            var result = await _studentService.RegisterStudentAsync(student);
            return CreatedAtAction(nameof(RegisterStudent), new { id = result.Id }, result);
        }

        [HttpPost("verify-otp")]
        public async Task<IActionResult> VerifyOTP([FromBody] VerifyOTPRequest request)
        {
            var isValid = await _studentService.VerifyOTPAsync(request.PhoneNumber, request.OTP);

            if (!isValid)
            {
                return BadRequest("Invalid OTP");
            }

            return Ok("Phone number verified successfully");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _studentService.GetAllStudentsAsync();
            return Ok(students);
        }
    }
}