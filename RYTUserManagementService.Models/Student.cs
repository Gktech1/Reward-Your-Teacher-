using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SchoolName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdateAt { get; set; }

        public int SchoolId { get; set; }

        public ICollection<Student> Students { get; set; }
    }

}
