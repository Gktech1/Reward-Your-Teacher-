using System.ComponentModel.DataAnnotations;
using RYTUserManagementService.Common.Utilities;

namespace RYTUserManagementService.Models
{
    [Table(name: "Students")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public Constants.Titles Title { get; set; }

        [StringLength(Constants.Max100Length)]
        public string FullName { get; set; }

        [StringLength(Constants.Max2000Length)]
        public string About { get; set; }
        public virtual IdentityUser User { get; set; }
        public ICollection<Student> Students { get; set; }
        public virtual IEnumerable<School> School { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdateAt { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    }



}
