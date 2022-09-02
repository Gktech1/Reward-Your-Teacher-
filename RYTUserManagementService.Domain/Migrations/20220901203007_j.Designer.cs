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
    [Migration("20220901203007_j")]
    partial class j
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
                            Id = "26cc9bb3-8686-4a05-8053-bf9dba358711",
                            ConcurrencyStamp = "f3eb1bfd-b448-45f5-9bbb-66e60f6ea26b",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "8dce0259-a1fe-4e99-81f6-92820ab590a5",
                            ConcurrencyStamp = "eacaab60-9dc6-41c9-beb8-de22121db4b1",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "de0724b1-d8c6-4601-9a07-4b0c7d345b03",
                            ConcurrencyStamp = "afb064ab-b61f-4fcc-9011-c56b7cd0f8e6",
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
                            CreatedAt = new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9681),
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
                            CreatedAt = new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9685),
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
                            CreatedAt = new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9193),
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
                            CreatedAt = new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(9200),
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
                            Id = "31a5f145-a30b-4405-973f-95913d939ee7",
                            About = "I am a student",
                            AccessFailedCount = 0,
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            ConcurrencyStamp = "1317d068-b4c8-43b6-807b-df38fdff93d2",
                            CreatedAt = new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(8036),
                            CreatedBy = "Dami",
                            EmailConfirmed = false,
                            FullName = "Jegede Moses",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolId = "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                            SecurityStamp = "acb5a9f2-8564-443a-ae1d-250e271d20da",
                            Title = 0,
                            TwoFactorEnabled = false,
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "710a0ae7-857b-49f7-99ab-9314e9c5cae5",
                            About = "I am a student",
                            AccessFailedCount = 0,
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            ConcurrencyStamp = "ca645e91-57ce-4223-b794-2d0d5ff304d7",
                            CreatedAt = new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(8057),
                            CreatedBy = "Dami",
                            EmailConfirmed = false,
                            FullName = "Jegede Esther",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SchoolId = "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                            SecurityStamp = "13a85ae3-7304-4f44-a6d2-0c6d0b02d8aa",
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
                            Id = "45d860a6-e040-48c8-be57-423f5eb4c93b",
                            About = "I am A Teacher",
                            AccessFailedCount = 0,
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            ConcurrencyStamp = "1f48f236-1014-4514-82af-1fa0a17d51f3",
                            CreatedAt = new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(7369),
                            CreatedBy = "Dami",
                            EmailConfirmed = false,
                            EndYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Ayooluwa Moses",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Position = "HeadSA",
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SecurityStamp = "a274bc90-8712-4e1d-863a-c2b927394121",
                            StartYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = 3,
                            TwoFactorEnabled = false,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = "Dami"
                        },
                        new
                        {
                            Id = "88fc3462-953c-4de2-a7bd-ad24d8a34dc4",
                            About = "I am A Teacher",
                            AccessFailedCount = 0,
                            Address = "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574",
                            ConcurrencyStamp = "1e97b297-281c-48f8-921e-34209ddf7435",
                            CreatedAt = new DateTime(2022, 9, 1, 21, 30, 5, 175, DateTimeKind.Local).AddTicks(7394),
                            CreatedBy = "Dami",
                            EmailConfirmed = false,
                            EndYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Tijani Moses",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Position = "HeadSA",
                            ProfileUrl = "https://unsplash.com/photos/mPnkjZ_9a8Q",
                            SecurityStamp = "955e47fd-cc85-459f-a52b-6cb305c8c357",
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
