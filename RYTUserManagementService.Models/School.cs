﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RYTUserManagementService.Common.Utilities;
using Microsoft.AspNetCore.Identity;

namespace RYTUserManagementService.Models
{
    [Table(name: "Schools")]
    public class School
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string SchoolName { get; set; }

        public virtual Address Address { get; set; }

        [StringLength(Constants.Max100Length)]
        public string Logo { get; set; }

        public Constants.SchoolType Type { get; set; }
        public ICollection<Student> Students { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    }
}
