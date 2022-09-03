﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RYTUserManagementService.Domain;

#nullable disable

namespace RYTUserManagementService.Domain.Migrations
{
    [DbContext(typeof(UserManagementDbContext))]
    [Migration("20220902120001_recent")]
    partial class recent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3b5658ca-ea19-4c14-ada7-40f4ea6da3e3",
                            ConcurrencyStamp = "3ac747c5-2336-48a4-89ed-59c9f9105384",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "bfaad3a6-0e00-4ba9-bc63-17a4e5bee2fd",
                            ConcurrencyStamp = "99abfeba-b3cc-4168-a714-c8db39d2f673",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "f382548c-30db-433d-891d-e9abef203bbe",
                            ConcurrencyStamp = "e1aebfad-b398-4092-a6e4-7ea174598815",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = "a7dd2ab0-289c-11ed-a261-0242ac120002",
                            City = "Benin",
                            Country = "Nigeria",
                            CreatedAt = new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1994),
                            CreatedBy = "Dami",
                            Latitude = 4.5646573999999998,
                            Longitude = 9.0,
                            State = "Edo",
                            StreetAddress = "Okuoromi Community",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "b01430ca-289c-11ed-a261-0242ac120002",
                            City = "Lagos",
                            Country = "Nigeria",
                            CreatedAt = new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1998),
                            CreatedBy = "Dami",
                            Latitude = 4.5646764657399999,
                            Longitude = 9.5600645699999998,
                            State = "Lagos",
                            StreetAddress = "Lagos Community",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "Dami"
                        });
                });

            modelBuilder.Entity("RYTUserManagementService.Models.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApiUser");
                });

            modelBuilder.Entity("RYTUserManagementService.Models.School", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AddressId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = "11f09734-289d-11ed-a261-0242ac120002",
                            AddressId = "a7dd2ab0-289c-11ed-a261-0242ac120002",
                            CreatedAt = new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1867),
                            CreatedBy = "Dami",
                            Logo = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolName = "Decagon Institute Edo",
                            Type = 1,
                            UpdatedAt = new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "21addd9e-289d-11ed-a261-0242ac120002",
                            AddressId = "b01430ca-289c-11ed-a261-0242ac120002",
                            CreatedAt = new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1874),
                            CreatedBy = "Dami",
                            Logo = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolName = "Decagon Institute Lagos",
                            Type = 1,
                            UpdatedAt = new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            UpdatedBy = "Dami"
                        });
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Student", b =>
                {
                    b.HasBaseType("RYTUserManagementService.Models.ApiUser");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ProfileUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Title")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("SchoolId");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = "93530ed2-c51b-4b4d-9655-a457b2bbc2ae",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8eb1cfdc-4082-4642-8532-597a893f5401",
                            EmailConfirmed = false,
                            FirstName = "bayo",
                            LastName = "dayo",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "604b372a-9e3b-4fec-979c-4966d20cd7ad",
                            TwoFactorEnabled = false,
                            UserRole = 0,
                            About = "I am a student",
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            CreatedAt = new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1684),
                            CreatedBy = "Dami",
                            FullName = "Jegede Moses",
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolId = "11f09734-289d-11ed-a261-0242ac120002",
                            Title = 0,
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "db714c91-d787-49de-bf36-ac9accead430",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "810665d9-8d3e-4cc1-8366-07248990e309",
                            EmailConfirmed = false,
                            FirstName = "bayo",
                            LastName = "dayo",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95b1654d-12e3-4d8e-9790-48f3337b5969",
                            TwoFactorEnabled = false,
                            UserRole = 0,
                            About = "I am a student",
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            CreatedAt = new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1705),
                            CreatedBy = "Dami",
                            FullName = "Jegede Esther",
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolId = "11f09734-289d-11ed-a261-0242ac120002",
                            Title = 1,
                            UpdatedBy = "Dami"
                        });
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Teacher", b =>
                {
                    b.HasBaseType("RYTUserManagementService.Models.ApiUser");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("Teacher_About");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Teacher_Address");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("Teacher_CreatedAt");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Teacher_CreatedBy");

                    b.Property<DateTime>("EndYear")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("Teacher_FullName");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ProfileUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("Teacher_ProfileUrl");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Teacher_SchoolId");

                    b.Property<DateTime>("StartYear")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Title")
                        .HasColumnType("integer")
                        .HasColumnName("Teacher_Title");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Teacher_UpdatedBy");

                    b.HasIndex("SchoolId");

                    b.HasDiscriminator().HasValue("Teacher");

                    b.HasData(
                        new
                        {
                            Id = "27f41870-0445-4a17-b54c-d78648196551",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "302c65a1-7f65-4294-b8f3-f2a1b4efe6ff",
                            EmailConfirmed = false,
                            FirstName = "bayo",
                            LastName = "dayo",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "376a3667-4335-4630-a06f-841a0d6b17da",
                            TwoFactorEnabled = false,
                            UserRole = 0,
                            About = "I am A Teacher",
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            CreatedAt = new DateTime(2022, 9, 2, 13, 0, 0, 365, DateTimeKind.Local).AddTicks(9644),
                            CreatedBy = "Dami",
                            EndYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Ayooluwa Moses",
                            Position = "HeadSA",
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolId = "11f09734-289d-11ed-a261-0242ac120002",
                            StartYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = 3,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "1a518c15-5f3d-4ef0-b1b7-690cf04b60a9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e27b9234-3784-4d77-9d4f-96150319ee72",
                            EmailConfirmed = false,
                            FirstName = "bayo",
                            LastName = "dayo",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6505ba86-d2fa-4ee7-b105-61a9a50aa184",
                            TwoFactorEnabled = false,
                            UserRole = 0,
                            About = "I am A Teacher",
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            CreatedAt = new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(89),
                            CreatedBy = "Dami",
                            EndYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Tijani Moses",
                            Position = "HeadSA",
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolId = "11f09734-289d-11ed-a261-0242ac120002",
                            StartYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = 4,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "Dami"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RYTUserManagementService.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RYTUserManagementService.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RYTUserManagementService.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RYTUserManagementService.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RYTUserManagementService.Models.School", b =>
                {
                    b.HasOne("RYTUserManagementService.Models.Address", "Address")
                        .WithMany("Schools")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Student", b =>
                {
                    b.HasOne("RYTUserManagementService.Models.School", "School")
                        .WithMany("Students")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Teacher", b =>
                {
                    b.HasOne("RYTUserManagementService.Models.School", "School")
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Address", b =>
                {
                    b.Navigation("Schools");
                });

            modelBuilder.Entity("RYTUserManagementService.Models.School", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
