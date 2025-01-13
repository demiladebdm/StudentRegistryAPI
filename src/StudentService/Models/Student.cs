using System.ComponentModel.DataAnnotations;

namespace StudentService.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string LGA { get; set; }

        public bool IsPhoneVerified { get; set; }
    }
}
