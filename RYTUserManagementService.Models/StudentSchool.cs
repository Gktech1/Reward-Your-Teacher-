using System.ComponentModel.DataAnnotations;
using RYTUserManagementService.Common.Utilities;

namespace RYTUserManagementService.Models
{
    public class Student
    {
        public int Id { get; set; }
        public virtual School School { get; set; }
        public virtual Student Student { get; set; }
    }

}
