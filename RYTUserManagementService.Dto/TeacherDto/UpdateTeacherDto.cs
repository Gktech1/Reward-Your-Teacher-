using Microsoft.AspNetCore.Identity;
using RYTUserManagementService.Common.Utilities;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Dto.TeacherDto;

public class UpdateTeacherDto : TeacherDto
{
    public Constants.Titles Title { get; set; }

    public string ProfileUrl { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string PhoneNumber { get; set; }

    public string Position { get; set; }

    public Address Address { get; set; }

    public SchoolDto SchoolName { get; set; }

    public string UserType { get; set; }

    public string Gender { get; set; }

}