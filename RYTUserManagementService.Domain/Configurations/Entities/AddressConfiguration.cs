using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RYTUserManagementService.Common.Utilities;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.Configurations.Entities
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {

            builder.HasData(
                new Address
                {
                    Id = "fa17534a-718d -40d5-97cd-7902c790c95a",
                    StreetAddress = "Okuoromi Community",
                    City = "Benin",
                    State = "Edo",
                    Country = "Nigeria",
                    Longitude = 9.0000000,
                    Latitude = 4.5646574,
                    CreatedBy = "Dami",
                    UpdatedBy = "Dami"
                },
                new Address
                {
                    Id = "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                    StreetAddress = "Lagos Community",
                    City = "Lagos",
                    State = "Lagos",
                    Country = "Nigeria",
                    Longitude = 9.560064570,
                    Latitude = 4.56467646574,
                    CreatedBy = "Dami",
                    UpdatedBy = "Dami"
                }

            );
        }
    }

}
