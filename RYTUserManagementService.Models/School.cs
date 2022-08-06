using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SchoolName { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
