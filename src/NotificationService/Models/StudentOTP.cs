using System.ComponentModel.DataAnnotations;

namespace NotificationService.Models
{
    public class StudentOTP
    {
        [Key]
        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsPhoneVerified { get; set; }
    }
}
