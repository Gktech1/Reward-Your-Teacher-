﻿using System;
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
                    Title = Constants.Titles.Mr,
                    FirstName = "bayo",
                    LastName = "dayo",
                    SchoolId = "11f09734-289d-11ed-a261-0242ac120002",
                    FullName = "Jegede Moses",
                    ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                    About = "I am a student",
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
                    SchoolId = "11f09734-289d-11ed-a261-0242ac120002",
                    FullName = "Jegede Esther",
                    ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                    About = "I am a student",
                    Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Dami",
                    UpdatedBy = "Dami"
                }
            ); ;
        }
    }
    
}