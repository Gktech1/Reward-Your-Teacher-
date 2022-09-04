using RYTUserManagementService.Common.Utilities;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Dto.TeacherDto;

public class UpdateTeacherDto
{
    public Constants.Titles Title { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Position { get; set; }

    public string? Address { get; set; }

    public string? SchoolName { get; set; }

    public string? UserType { get; set; }

    public string? Gender { get; set; }

}