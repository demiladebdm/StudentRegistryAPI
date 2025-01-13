using Microsoft.EntityFrameworkCore;
using NotificationService.Interfaces;

namespace NotificationService.Services
{
    public class NotificationService : INotificationService
    {
        private static readonly Dictionary<string, string> _otpStore = new();

        public Task<string> GenerateAndSendOTPAsync(string phoneNumber)
        {
            var otp = new Random().Next(100000, 999999).ToString();
            _otpStore[phoneNumber] = otp;
            Console.WriteLine($"Sending OTP {otp} to {phoneNumber}"); // Mock sending OTP
            return Task.FromResult(otp);
        }

        public bool VerifyStoredOTP(string phoneNumber, string otp)
        {
            return _otpStore.ContainsKey(phoneNumber) && _otpStore[phoneNumber] == otp;
        }

        public void ClearOTP(string phoneNumber)
        {
            _otpStore.Remove(phoneNumber);
        }
    }
}