using NotificationService.Interfaces;

namespace NotificationService.Utilities
{
    public class OTPGenerator : IOTPGenerator
    {
        public string GenerateOTP()
        {
            return new Random().Next(100000, 999999).ToString();
        }
    }
}
