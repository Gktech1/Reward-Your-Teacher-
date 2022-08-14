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
                    Id = Guid.NewGuid().ToString(),
                    SchoolName = "Decagon Institute Edo",
                    AddressId = _address.Id,
                    Logo = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                    Type = Constants.SchoolType.Secondary,
                    Students = new List<Student>(),
                    Teachers = new List<Teacher>(),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Dami",
                    UpdatedAt = DateTime.Today,
                    UpdatedBy = "Dami"

                },
                new School
                {
                    Id = Guid.NewGuid().ToString(),
                    SchoolName = "Decagon Institute Lagos",
                    AddressId = _address.Id,
                    Logo = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                    Type = Constants.SchoolType.Secondary,
                    Students = new List<Student>(),
                    Teachers = new List<Teacher>(),
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Dami",
                    UpdatedAt = DateTime.Today,
                    UpdatedBy = "Dami"
                }
            );

        }
    }
}
