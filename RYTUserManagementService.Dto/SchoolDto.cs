using RYTUserManagementService.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using RYTUserManagementService.Common.Utilities;

namespace RYTUserManagementService.Dto
{
    public class SchoolDto 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SchoolName { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
        public ICollection<StudentsDto> Students { get; set; }

        public ICollection<TeacherDto> Teachers { get; set; }
    }

    public class UpdateSchoolDto : SchoolDto
    {
        [StringLength(Constants.Max100Length)]
        public School Logo { get; set; }

        public School SchoolName { get; set; }

        public IdentityUser Password { get; set; }

        public IdentityUser PhoneNumber { get; set; }

        public Address Address { get; set; }

        public Constants.SchoolType SchoolType { get; set; }

        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

    }
}
