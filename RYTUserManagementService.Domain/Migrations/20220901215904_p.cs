using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RYTUserManagementService.Domain.Migrations
{
    public partial class p : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolTeacher_Teachers_TeachersId",
                table: "SchoolTeacher");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26ed916a-f1ea-4ccb-929b-49d1c2ba6f8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2deeae0a-a0a5-4066-bfd4-b249074f511b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44b5f15f-100b-4a64-937b-d6c1e130c379");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "AspNetUsers",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndYear",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "AspNetUsers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileUrl",
                table: "AspNetUsers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolId",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartYear",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_About",
                table: "AspNetUsers",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_Address",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Teacher_CreatedAt",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_CreatedBy",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_FullName",
                table: "AspNetUsers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_ProfileUrl",
                table: "AspNetUsers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Teacher_Title",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_UpdatedBy",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "AspNetUsers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 59, 3, 675, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "fa17534a-718d -40d5-97cd-7902c790c95a",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 59, 3, 675, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "609c8f60-915e-4d32-bc6c-16306a70be0c", "c74229a4-b15a-4c2e-9a52-43d273cccd1a", "Administrator", "ADMINISTRATOR" },
                    { "a12b942f-e79d-49e2-a4dc-8a513a52a28f", "2ba5d88b-0c34-4aae-8d64-2cca4327d328", "Student", "STUDENT" },
                    { "c4feecbf-6c97-4724-b5b8-6ca30d028aad", "16855a0b-b9d1-4c83-8b80-cb612f300430", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Discriminator", "Email", "EmailConfirmed", "FirstName", "FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SchoolId", "SecurityStamp", "Title", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "36cb8536-b9c1-4423-be04-99d3069124bb", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "42dbb96d-0ea8-4727-b4cb-230282945522", new DateTime(2022, 9, 1, 22, 59, 3, 675, DateTimeKind.Local).AddTicks(1450), "Dami", "Student", null, false, "bayo", "Jegede Moses", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "8691ffe5-4273-42d0-9a59-bed24eb5af6e", "8541ba24-5d0b-45b6-960b-374f461b26e0", 0, false, "Dami", null },
                    { "cfa86284-e28d-4048-a4f3-770ebface54a", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "e7e6d2c1-157c-463d-b670-f45ab777693d", new DateTime(2022, 9, 1, 22, 59, 3, 675, DateTimeKind.Local).AddTicks(1474), "Dami", "Student", null, false, "bayo", "Jegede Esther", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "8691ffe5-4273-42d0-9a59-bed24eb5af6e", "63f6b9e2-8eab-4104-96e0-15357189601d", 1, false, "Dami", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "Teacher_About", "AccessFailedCount", "Teacher_Address", "ConcurrencyStamp", "Teacher_CreatedAt", "Teacher_CreatedBy", "Discriminator", "Email", "EmailConfirmed", "EndYear", "FirstName", "Teacher_FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Teacher_ProfileUrl", "SecurityStamp", "StartYear", "Teacher_Title", "TwoFactorEnabled", "UpdateAt", "Teacher_UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "5431bbbc-251d-4cba-8057-2f6f61fa3e4e", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "088f1083-dabf-4589-877d-b066b7dacd88", new DateTime(2022, 9, 1, 22, 59, 3, 675, DateTimeKind.Local).AddTicks(889), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Tijani Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "eba8bcd4-3509-4134-a6b3-0a71dfcfa05e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "6a850197-8754-45f1-b75e-4df7228d8b98", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "e610101e-1d20-48c9-a822-7bd4255fb144", new DateTime(2022, 9, 1, 22, 59, 3, 675, DateTimeKind.Local).AddTicks(862), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Ayooluwa Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "a12ae70d-ced3-4f7d-9f33-d9237e6d4a8a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "680b8ddb-6842-46fc-ae90-89e334157731",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 59, 3, 675, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 59, 3, 675, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SchoolId",
                table: "AspNetUsers",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Schools_SchoolId",
                table: "AspNetUsers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolTeacher_AspNetUsers_TeachersId",
                table: "SchoolTeacher",
                column: "TeachersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Schools_SchoolId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolTeacher_AspNetUsers_TeachersId",
                table: "SchoolTeacher");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SchoolId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "609c8f60-915e-4d32-bc6c-16306a70be0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a12b942f-e79d-49e2-a4dc-8a513a52a28f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4feecbf-6c97-4724-b5b8-6ca30d028aad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36cb8536-b9c1-4423-be04-99d3069124bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa86284-e28d-4048-a4f3-770ebface54a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5431bbbc-251d-4cba-8057-2f6f61fa3e4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a850197-8754-45f1-b75e-4df7228d8b98");

            migrationBuilder.DropColumn(
                name: "About",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EndYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StartYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Teacher_About",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Teacher_Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Teacher_CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Teacher_CreatedBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Teacher_FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Teacher_ProfileUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Teacher_Title",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Teacher_UpdatedBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    SchoolId = table.Column<string>(type: "text", nullable: false),
                    About = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    ProfileUrl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    About = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    EndYear = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    Position = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ProfileUrl = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    StartYear = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Title = table.Column<int>(type: "integer", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7c1e2be3-53a4-4dec-948d-d4e2e2face50",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "fa17534a-718d -40d5-97cd-7902c790c95a",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26ed916a-f1ea-4ccb-929b-49d1c2ba6f8c", "bb021d2c-2499-4c4e-a126-64fb37cf6902", "Administrator", "ADMINISTRATOR" },
                    { "2deeae0a-a0a5-4066-bfd4-b249074f511b", "3de8ceae-853d-4248-92ac-ed310ce8c09b", "Teacher", "TEACHER" },
                    { "44b5f15f-100b-4a64-937b-d6c1e130c379", "0c72cd9a-c055-41e7-8c5d-bafee45f7def", "Student", "STUDENT" }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "680b8ddb-6842-46fc-ae90-89e334157731",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "8691ffe5-4273-42d0-9a59-bed24eb5af6e",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SchoolId", "SecurityStamp", "Title", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "36e00b0a-4823-4e45-b867-18302291ab79", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "dd758745-c422-4420-8805-6436cdea83dc", new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3529), "Dami", null, false, "Jegede Esther", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "8691ffe5-4273-42d0-9a59-bed24eb5af6e", "2c2ae121-9292-49e5-9d80-9f4aadaec6cb", 1, false, "Dami", null },
                    { "ecf29d49-8d8d-4411-9859-61fd62ef2b70", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "6d5ad5cc-c4d9-4b1a-ae35-01e339c1c0e3", new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3518), "Dami", null, false, "Jegede Moses", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "8691ffe5-4273-42d0-9a59-bed24eb5af6e", "7b84d5e1-8161-490c-885a-5b9bcf9ff267", 0, false, "Dami", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "EndYear", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "ProfileUrl", "SecurityStamp", "StartYear", "Title", "TwoFactorEnabled", "UpdateAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { "6ff2a432-e3f7-4408-bdb5-c8afb6f8eaeb", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "66fce208-41c9-44dc-9cf5-f96677e31455", new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3298), "Dami", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tijani Moses", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "77aad4e7-9a25-4447-85aa-cb3ed37839e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null },
                    { "85a7ce54-d917-4fc4-9ef5-5682e8c985ca", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "34807301-551a-4fca-823b-56f79e64b49d", new DateTime(2022, 9, 1, 22, 48, 13, 309, DateTimeKind.Local).AddTicks(3280), "Dami", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayooluwa Moses", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "20d370f8-eb39-48f5-8631-f1ea37b3977a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolTeacher_Teachers_TeachersId",
                table: "SchoolTeacher",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
