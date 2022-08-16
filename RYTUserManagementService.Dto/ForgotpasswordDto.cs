
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace RYTUserManagementService.Dto
{
    public class ForgotpasswordDto
    {
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}