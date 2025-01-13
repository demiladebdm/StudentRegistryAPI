namespace NotificationService.Interfaces
{
    public interface INotificationService
    {
        Task<string> GenerateAndSendOTPAsync(string phoneNumber);
        //Task<bool> VerifyOTPAsync(string phoneNumber, string otp);


        bool VerifyStoredOTP(string phoneNumber, string otp);
        void ClearOTP(string phoneNumber);
    }
}
