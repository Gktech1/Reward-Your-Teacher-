using Microsoft.AspNetCore.Identity;
using RYTUserManagementService.Common.Utilities;
using RYTUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Dto
{
    public class SchoolDTO
    {
        public School Logo { get; set; }

        public School SchoolName { get; set; }

        public IdentityUser Password { get; set; }

        public IdentityUser PhoneNumber { get; set; }

        public Address Address { get; set; }

        public Constants.SchoolType SchoolType { get; set; }

        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

    }
}
