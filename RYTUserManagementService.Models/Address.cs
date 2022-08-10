using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Common.Utilities;

namespace RYTUserManagementService.Models
{
    [Table(name: "Addresses")]
    public class Address
    {
        [StringLength(Constants.Max2000Length)]
        public string Address { get; set; }

        [StringLength(Constants.Max100Length)]
        public string City { get; set; }

        [StringLength(Constants.Max100Length)]
        public string State { get; set; }


        [StringLength(Constants.Max100Length)]
        public string Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
