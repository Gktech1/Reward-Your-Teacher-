using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using RYTUserManagementService.Common.Utilities;

namespace RYTUserManagementService.Models
{
    public class TeacherSchool
    {
        public int Id { get; set; }
        public virtual School School { get; set; }
        public virtual Teacher Teacher { get; set; }   

    }
}
