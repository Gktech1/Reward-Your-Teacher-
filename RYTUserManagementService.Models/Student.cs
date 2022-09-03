using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using RYTUserManagementService.Common.Utilities;

namespace RYTUserManagementService.Models
{
    public class Student : ApiUser
    {
        public Constants.Titles Title { get; set; }

        [StringLength(Constants.Max200Length)]
        public string ProfileUrl { get; set; }

        [StringLength(Constants.Max100Length)]
        public string FullName { get; set; }

        [StringLength(Constants.Max2000Length)]
        public string About { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.ToLocalTime();

        public string SchoolName { get; set; }

        public string Address { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; } 
    }
}
