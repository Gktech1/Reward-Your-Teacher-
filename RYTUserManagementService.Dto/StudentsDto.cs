using RYTUserManagementService.Models;
using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Dto
{
    public class StudentsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SchoolName { get; set; }
    }
}
