using Microsoft.AspNetCore.Identity;
using RYTUserManagementService.Common.Utilities;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Dto.StudentDto;

public class CreateStudentDto : StudentsDto
{

    public Constants.Titles Title { get; set; }
    public string ProfileUrl { get; set; }

    public string Email { get; set; }
    public string UserName { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }

}