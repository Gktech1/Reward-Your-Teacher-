using RYTUserManagementService.Models;
using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Dto
{
    public class UpdateSchoolDto
    {

        [Required]
        public string SchoolName { get; set; }

        [Required]
        public string Address { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

    }
}