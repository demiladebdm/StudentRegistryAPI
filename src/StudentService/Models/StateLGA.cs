using System.ComponentModel.DataAnnotations;

namespace StudentService.Models
{
    public class StateLGA
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string LGA { get; set; }
        public bool IsActive { get; set; } = false;
    }
}