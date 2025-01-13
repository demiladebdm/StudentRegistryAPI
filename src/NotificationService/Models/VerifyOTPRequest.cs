namespace NotificationService.Models
{
    public class VerifyOTPRequest
    {
        public string PhoneNumber { get; set; }
        public string OTP { get; set; }
    }
}
