using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RYTUserManagementService.Domain.Migrations
{
    public partial class recent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3afef8f5-5f56-4498-8039-9cd766437a49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6044a881-c77d-4caf-a8d7-8339f4e75feb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3506fb1-0c7a-4961-90ab-fe7b5fdf0556");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109f26dc-85d1-49a9-b02b-fb46f5b05f6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfd51f44-1028-4521-9436-f9036302d15c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75b04886-f726-4d9f-83f7-cc31d138d5bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "827e6621-f9d6-42e4-9791-82d1d7e19733");

            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "a7dd2ab0-289c-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "b01430ca-289c-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b5658ca-ea19-4c14-ada7-40f4ea6da3e3", "3ac747c5-2336-48a4-89ed-59c9f9105384", "Student", "STUDENT" },
                    { "bfaad3a6-0e00-4ba9-bc63-17a4e5bee2fd", "99abfeba-b3cc-4168-a714-c8db39d2f673", "Administrator", "ADMINISTRATOR" },
                    { "f382548c-30db-433d-891d-e9abef203bbe", "e1aebfad-b398-4092-a6e4-7ea174598815", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Discriminator", "Email", "EmailConfirmed", "FirstName", "FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileUrl", "SchoolId", "SecurityStamp", "Title", "TwoFactorEnabled", "UpdatedBy", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "93530ed2-c51b-4b4d-9655-a457b2bbc2ae", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "8eb1cfdc-4082-4642-8532-597a893f5401", new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1684), "Dami", "Student", null, false, "bayo", "Jegede Moses", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "604b372a-9e3b-4fec-979c-4966d20cd7ad", 0, false, "Dami", null, 0 },
                    { "db714c91-d787-49de-bf36-ac9accead430", "I am a student", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "810665d9-8d3e-4cc1-8366-07248990e309", new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1705), "Dami", "Student", null, false, "bayo", "Jegede Esther", "dayo", false, null, null, null, null, null, false, "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "95b1654d-12e3-4d8e-9790-48f3337b5969", 1, false, "Dami", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "Teacher_About", "AccessFailedCount", "Teacher_Address", "ConcurrencyStamp", "Teacher_CreatedAt", "Teacher_CreatedBy", "Discriminator", "Email", "EmailConfirmed", "EndYear", "FirstName", "Teacher_FullName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Teacher_ProfileUrl", "Teacher_SchoolId", "SecurityStamp", "StartYear", "Teacher_Title", "TwoFactorEnabled", "UpdateAt", "Teacher_UpdatedBy", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "1a518c15-5f3d-4ef0-b1b7-690cf04b60a9", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "e27b9234-3784-4d77-9d4f-96150319ee72", new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(89), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Tijani Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "6505ba86-d2fa-4ee7-b105-61a9a50aa184", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null, 0 },
                    { "27f41870-0445-4a17-b54c-d78648196551", "I am A Teacher", 0, "Okuoromi Community,Benin, Edo, Nigeria, 9.0000000, 4.5646574", "302c65a1-7f65-4294-b8f3-f2a1b4efe6ff", new DateTime(2022, 9, 2, 13, 0, 0, 365, DateTimeKind.Local).AddTicks(9644), "Dami", "Teacher", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bayo", "Ayooluwa Moses", "dayo", false, null, null, null, null, null, false, "HeadSA", "https://unsplash.com/photos/mPnkjZ_9a8Q", "11f09734-289d-11ed-a261-0242ac120002", "376a3667-4335-4630-a06f-841a0d6b17da", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dami", null, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "11f09734-289d-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "21addd9e-289d-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 13, 0, 0, 366, DateTimeKind.Local).AddTicks(1874));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b5658ca-ea19-4c14-ada7-40f4ea6da3e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfaad3a6-0e00-4ba9-bc63-17a4e5bee2fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f382548c-30db-433d-891d-e9abef203bbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93530ed2-c51b-4b4d-9655-a457b2bbc2ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db714c91-d787-49de-bf36-ac9accead430");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a518c15-5f3d-4ef0-b1b7-690cf04b60a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27f41870-0445-4a17-b54c-d78648196551");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "a7dd2ab0-289c-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "b01430ca-289c-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4692));

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

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "11f09734-289d-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: "21addd9e-289d-11ed-a261-0242ac120002",
                column: "CreatedAt",
                value: new DateTime(2022, 9, 2, 3, 15, 27, 408, DateTimeKind.Local).AddTicks(4403));
        }
    }
}
