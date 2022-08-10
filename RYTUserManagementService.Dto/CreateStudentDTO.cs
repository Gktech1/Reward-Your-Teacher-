using Microsoft.AspNetCore.Identity;
using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Dto
{
    public class CreateStudentDTO 
    {
        public Student Title { get; set; }
        public string FullName { get; set; }
        public string ProfileUrl { get; set; }

        public string Email { get; set; }
  
        public IdentityUser Password { get; set; }

        public IdentityUser PhoneNumber { get; set; }

        public Address Address { get; set; }

        public School SchoolName { get; set; }

        public IdentityUser UserType { get; set; }

        public IdentityUser Gender { get; set; }

        public Student About { get; set; }

    }
}
