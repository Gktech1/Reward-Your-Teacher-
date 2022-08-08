using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Models
{
    public class Teacher : IdentityUser
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = ModelValidationErrors.DataInputError)]
        public string Password { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = ModelValidationErrors.ConfirmPasswordError)]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdateAt { get; set; }

        public int SchoolId { get; set; }

        public string Position { get; set; }

        public DateTime StartYear { get; set; }

        public DateTime EndYear { get; set; }

        public School School { get; set; }


    }
}
