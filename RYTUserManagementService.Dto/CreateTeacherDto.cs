using RYTUserManagementService.Models;
using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Dto
{
    public class CreateTeacherDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = ModelValidationErrors.DataInputError)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = ModelValidationErrors.ConfirmPasswordError)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int SchoolId { get; set; }
        public string Position { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
        public School School { get; set; }
    }
}
