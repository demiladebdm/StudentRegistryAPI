using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationService.Interfaces;
using NotificationService.Models;

namespace NotificationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OTPController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public OTPController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GenerateOTP([FromBody] GenerateOTPRequest request)
        {
            var otp = await _notificationService.GenerateAndSendOTPAsync(request.PhoneNumber);
            return Ok(new { PhoneNumber = request.PhoneNumber, OTP = otp });
        }

        //[HttpPost("verify")]
        //public async Task<IActionResult> VerifyOTP([FromBody] VerifyOTPRequest request)
        //{
        //    var isValid = await _notificationService.VerifyOTPAsync(request.PhoneNumber, request.OTP);

        //    if (!isValid)
        //    {
        //        return BadRequest("Invalid OTP");
        //    }

        //    return Ok("OTP verified successfully");
        //}
    }
}
