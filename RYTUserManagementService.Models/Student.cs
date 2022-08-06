namespace RYTUserManagementService.Models
{
    public class Student
    {
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
