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
    [Migration("20220901214814_h")]
    partial class h
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
                            Id = "44b5f15f-100b-4a64-937b-d6c1e130c379",
                            ConcurrencyStamp = "0c72cd9a-c055-41e7-8c5d-bafee45f7def",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "26ed916a-f1ea-4ccb-929b-49d1c2ba6f8c",
                            ConcurrencyStamp = "bb021d2c-2499-4c4e-a126-64fb37cf6902",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2deeae0a-a0a5-4066-bfd4-b249074f511b",
                            ConcurrencyStamp = "3de8ceae-853d-4248-92ac-ed310ce8c09b",
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
                            Id = "fa17534a-718d -40d5-97cd-7902c790c95a",
                            City = "Benin",
                            Country = "Nigeria",
                            CreatedAt = new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3808),
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
                            Id = "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                            City = "Lagos",
                            Country = "Nigeria",
                            CreatedAt = new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3811),
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

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
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
                            Id = "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                            AddressId = "fa17534a-718d -40d5-97cd-7902c790c95a",
                            CreatedAt = new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3589),
                            CreatedBy = "Dami",
                            Logo = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolName = "Decagon Institute Edo",
                            Type = 1,
                            UpdatedAt = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "680b8ddb-6842-46fc-ae90-89e334157731",
                            AddressId = "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                            CreatedAt = new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3594),
                            CreatedBy = "Dami",
                            Logo = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolName = "Decagon Institute Lagos",
                            Type = 1,
                            UpdatedAt = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            UpdatedBy = "Dami"
                        });
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("ProfileUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("SchoolId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("Title")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = "ecf29d49-8d8d-4411-9859-61fd62ef2b70",
                            About = "I am a student",
                            AccessFailedCount = 0,
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            ConcurrencyStamp = "6d5ad5cc-c4d9-4b1a-ae35-01e339c1c0e3",
                            CreatedAt = new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3518),
                            CreatedBy = "Dami",
                            EmailConfirmed = false,
                            FullName = "Jegede Moses",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolId = "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                            SecurityStamp = "7b84d5e1-8161-490c-885a-5b9bcf9ff267",
                            Title = 0,
                            TwoFactorEnabled = false,
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "36e00b0a-4823-4e45-b867-18302291ab79",
                            About = "I am a student",
                            AccessFailedCount = 0,
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            ConcurrencyStamp = "dd758745-c422-4420-8805-6436cdea83dc",
                            CreatedAt = new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3529),
                            CreatedBy = "Dami",
                            EmailConfirmed = false,
                            FullName = "Jegede Esther",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolId = "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                            SecurityStamp = "2c2ae121-9292-49e5-9d80-9f4aadaec6cb",
                            Title = 1,
                            TwoFactorEnabled = false,
                            UpdatedBy = "Dami"
                        });
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("EndYear")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ProfileUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartYear")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Title")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = "85a7ce54-d917-4fc4-9ef5-5682e8c985ca",
                            About = "I am A Teacher",
                            AccessFailedCount = 0,
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            ConcurrencyStamp = "34807301-551a-4fca-823b-56f79e64b49d",
                            CreatedAt = new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3280),
                            CreatedBy = "Dami",
                            EmailConfirmed = false,
                            EndYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Ayooluwa Moses",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Position = "HeadSA",
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SecurityStamp = "20d370f8-eb39-48f5-8631-f1ea37b3977a",
                            StartYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = 3,
                            TwoFactorEnabled = false,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "6ff2a432-e3f7-4408-bdb5-c8afb6f8eaeb",
                            About = "I am A Teacher",
                            AccessFailedCount = 0,
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            ConcurrencyStamp = "66fce208-41c9-44dc-9cf5-f96677e31455",
                            CreatedAt = new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3298),
                            CreatedBy = "Dami",
                            EmailConfirmed = false,
                            EndYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Tijani Moses",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Position = "HeadSA",
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SecurityStamp = "77aad4e7-9a25-4447-85aa-cb3ed37839e3",
                            StartYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = 4,
                            TwoFactorEnabled = false,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "Dami"
                        });
                });

            modelBuilder.Entity("SchoolTeacher", b =>
                {
                    b.Property<string>("SchoolId")
                        .HasColumnType("text");

                    b.Property<string>("TeachersId")
                        .HasColumnType("text");

                    b.HasKey("SchoolId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("SchoolTeacher");
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

            modelBuilder.Entity("SchoolTeacher", b =>
                {
                    b.HasOne("RYTUserManagementService.Models.School", null)
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RYTUserManagementService.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RYTUserManagementService.Models.Address", b =>
                {
                    b.Navigation("Schools");
                });

            modelBuilder.Entity("RYTUserManagementService.Models.School", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
