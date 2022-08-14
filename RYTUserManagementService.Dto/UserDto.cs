using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RYTUserManagementService.Dto
{

    public class LoginUserDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to 15 characters", MinimumLength = 4)]
        public string Password { get; set; }

        public ICollection<string> Roles { get; set; }
    }

    public class UserDto : LoginUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Password)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to 15 characters", MinimumLength = 4)]
        public string Password { get; set; }
    }
}
