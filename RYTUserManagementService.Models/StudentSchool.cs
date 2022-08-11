using System.ComponentModel.DataAnnotations;
using RYTUserManagementService.Common.Utilities;

namespace RYTUserManagementService.Models
{
    public class StudentSchool
    {
        public int Id { get; set; }
        public virtual School School { get; set; }
        public virtual Student Student { get; set; }
    }

}
