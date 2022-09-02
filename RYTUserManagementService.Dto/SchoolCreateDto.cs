using RYTUserManagementService.Common.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace RYTUserManagementService.Dto
{
    public class SchoolCreateDto
    {
        [Required]
        [StringLength(Constants.Max100Length)]
        public string SchoolName { get; set; }

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string AddressId { get; set; }
    }
}
