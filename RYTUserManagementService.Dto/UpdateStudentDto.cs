using RYTUserManagementService.Models;

namespace RYTUserManagementService.Dto
{
    public class UpdateStudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public DateTime UpdateAt { get; set; } = DateTime.Now;

        public int SchoolId { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
