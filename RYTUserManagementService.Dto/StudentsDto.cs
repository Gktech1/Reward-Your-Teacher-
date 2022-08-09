using RYTUserManagementService.Models;
using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Dto
{
    public class StudentsDto
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdateAt { get; set; }

        public int SchoolId { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
