using System.ComponentModel.DataAnnotations;

namespace StudentService.DTOs
{
    public class StudentsDto
    {
        [Required]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Invalid phone number format.")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string LGA { get; set; }
    }
}
