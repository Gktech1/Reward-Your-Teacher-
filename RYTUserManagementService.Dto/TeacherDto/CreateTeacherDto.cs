using RYTUserManagementService.Common.Utilities;

namespace RYTUserManagementService.Dto.TeacherDto
{
    public class CreateTeacherDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SchoolName { get; set; }
        public string Password { get; set; }
        public string About { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }
        public Constants.Titles Title { get; set; }
        public string ProfileUrl { get; set; }
        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string SchoolId { get; set; }
    }
}
