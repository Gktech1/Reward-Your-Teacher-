using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RYTUserManagementService.Domain.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    StreetAddress = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    SchoolName = table.Column<string>(type: "text", nullable: false),
                    AddressId = table.Column<string>(type: "text", nullable: false),
                    Logo = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: true),
                    ProfileUrl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    About = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    SchoolId = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    Teacher_Title = table.Column<int>(type: "integer", nullable: true),
                    Teacher_FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Teacher_ProfileUrl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Position = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Teacher_About = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    StartYear = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndYear = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Teacher_Address = table.Column<string>(type: "text", nullable: true),
                    Teacher_SchoolId = table.Column<string>(type: "text", nullable: true),
                    Teacher_CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Teacher_CreatedBy = table.Column<string>(type: "text", nullable: true),
                    Teacher_UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Schools_Teacher_SchoolId",
                        column: x => x.Teacher_SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedAt", "CreatedBy", "Latitude", "Longitude", "State", "StreetAddress", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "a7dd2ab0-289c-11ed-a261-0242ac120002", "Benin", "Nigeria", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4685), "Dami", 4.5646573999999998, 9.0, "Edo", "Okuoromi Community", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami" },
                    { "b01430ca-289c-11ed-a261-0242ac120002", "Lagos", "Nigeria", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4692), "Dami", 4.5646764657399999, 9.5600645699999998, "Lagos", "Lagos Community", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3afef8f5-5f56-4498-8039-9cd766437a49", "a8f02da8-b6c3-485c-82c8-35881890744d", "Student", "STUDENT" },
                    { "6044a881-c77d-4caf-a8d7-8339f4e75feb", "b096193d-6890-46d3-89fd-628dae7a12d1", "Teacher", "TEACHER" },
                    { "a3506fb1-0c7a-4961-90ab-fe7b5fdf0556", "a9d31d98-e6c7-4c86-8bb5-bf1f5fac673b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "AddressId", "CreatedAt", "CreatedBy", "Logo", "SchoolName", "Type", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "11f09734-289d-11ed-a261-0242ac120002", "a7dd2ab0-289c-11ed-a261-0242ac120002", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4397), "Dami", "https://unsplash.com/photos/mPnkjZ_9a8Q", "Decagon Institute Edo", 1, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Dami" },
                    { "21addd9e-289d-11ed-a261-0242ac120002", "b01430ca-289c-11ed-a261-0242ac120002", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4403), "Dami", "https://unsplash.com/photos/mPnkjZ_9a8Q", "Decagon Institute Lagos", 1, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Dami" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Discriminator", "Email", "EmailConfirmed", "FirstName", "FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SchoolId", "SecurityStamp", "Title", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "109f26dc-85d1-49a9-b02b-fb46f5b05f6c", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "d8d6e271-737c-4ca7-84c3-cf55bfc25e78", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4307), "Dami", "Student", null, false, "bayo", "Jegede Esther", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "778df6a3-712f-489f-85d7-b80275d0428e", 1, false, "Dami", null },
                    { "bfd51f44-1028-4521-9436-f9036302d15c", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "f2e8562f-d717-4189-a4a0-26eb3d5e8e82", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4292), "Dami", "Student", null, false, "bayo", "Jegede Moses", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "4afc8adb-98e0-40ef-92b9-9530764160af", 0, false, "Dami", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "Teacher_About", "AccessFailedCount", "Teacher_Address", "ConcurrencyStamp", "Teacher_CreatedAt", "Teacher_CreatedBy", "Discriminator", "Email", "EmailConfirmed", "EndYear", "FirstName", "Teacher_FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Teacher_ProfileUrl", "Teacher_SchoolId", "SecurityStamp", "StartYear", "Teacher_Title", "TwoFactorEnabled", "UpdateAt", "Teacher_UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "75b04886-f726-4d9f-83f7-cc31d138d5bd", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "7780d4ac-795b-4336-9758-e754c68ce239", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(3762), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Ayooluwa Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "21d460f2-bf21-4975-a398-005b543d17e1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "827e6621-f9d6-42e4-9791-82d1d7e19733", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "8caa8a7b-263e-4d46-9203-0ba428e1d552", new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(3786), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Tijani Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "e8a9a6a0-c411-466d-9a9f-3dc47d5d4dbe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SchoolId",
                table: "AspNetUsers",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Teacher_SchoolId",
                table: "AspNetUsers",
                column: "Teacher_SchoolId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schools_AddressId",
                table: "Schools",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
