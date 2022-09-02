using RYTUserManagementService.Models;

namespace RYTUserManagementService.Dto.StudentDto
{
    public class StudentsDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SchoolName { get; set; }
        public string Password { get; set; }
        public string About { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

    }
}
