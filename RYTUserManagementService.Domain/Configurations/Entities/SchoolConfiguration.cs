using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RYTUserManagementService.Common.Utilities;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.Configurations.Entities
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        private readonly Address _address = new Address();
        public void Configure(EntityTypeBuilder<School> builder)
        {

            builder.HasData(
                new School
                {
                    Id = "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                    SchoolName = "Decagon Institute Edo",
                    AddressId = "fa17534a-718d -40d5-97cd-7902c790c95a",
                    Logo = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                    Type = Constants.SchoolType.Secondary,
                    //Students = new List<Student>(),
                    //Teachers = new List<Teacher>(),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Dami",
                    UpdatedAt = DateTime.Today,
                    UpdatedBy = "Dami"

                },
                new School
                {
                    Id = "680b8ddb-6842-46fc-ae90-89e334157731",
                    SchoolName = "Decagon Institute Lagos",
                    AddressId = "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                    Logo = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                    Type = Constants.SchoolType.Secondary,
                    //Students = new List<Student>(),
                    //Teachers = new List<Teacher>(),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Dami",
                    UpdatedAt = DateTime.Today,
                    UpdatedBy = "Dami"
                }
            );

        }
    }
}
