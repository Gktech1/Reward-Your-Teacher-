using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Models
{
    public static class ModelValidationErrors
    {
        public const string DataInputError = "Password should not be more than 50 characters";
        public const string ConfirmPasswordError = "Password must match with confirm password";
    }
}
