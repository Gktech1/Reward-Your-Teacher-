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
    public class StudentConfiguration: IEntityTypeConfiguration<Student>
    {
      
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "bayo",
                    LastName  = "dayo",
                    Title = Constants.Titles.Mr,
                    FullName = "Jegede Moses",
                    ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                    About = "I am a student",
                    SchoolId = "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                    Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Dami",
                    UpdatedBy = "Dami"
                }, 
                new Student
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "bayo",
                    LastName = "dayo",
                    Title = Constants.Titles.Mrs,
                    FullName = "Jegede Esther",
                    ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                    About = "I am a student",
                    SchoolId = "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                    Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Dami",
                    UpdatedBy = "Dami"
                }
            );
        }
    }
    
}
