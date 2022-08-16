using RYTUserManagementService.Models;
using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Dto
{
    public class CreateStudentDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Student> Students { get; set; }

        //public string? PasswordResetToken { get; set; } 

       // public DateTime? ResetTokenExpires { get; set; }
    }
}
