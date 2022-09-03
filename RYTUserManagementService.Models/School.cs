﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RYTUserManagementService.Common.Utilities;
using Microsoft.AspNetCore.Identity;

namespace RYTUserManagementService.Models
{

    public class School : BaseEntity
    {
        
        public string SchoolName { get; set; }

        public string AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }


        public string Logo { get; set; }

        public Constants.SchoolType Type { get; set; }

        public ICollection<Teacher> Teachers { get; set; }



    }
}
