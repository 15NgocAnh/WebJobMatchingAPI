using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebJobMatchingAPI.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("442da925-b4bc-41ba-b277-c8d0917595e1"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("7dad4995-c714-4094-9767-a49acdfe5b9f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("b00943d6-a50c-4a53-9b01-8b3e46e68c15"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "skills",
                columns: new[] { "Id", "Name", "UsersID" },
                values: new object[,]
                {
                    { 1, "BACKEND", null },
                    { 2, "FONTEND", null }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "ID", "BirthDay", "Education", "Email", "Experience", "FirstName", "IsDeleted", "IsEmailConfirmed", "IsLocked", "IsMale", "JobsId", "LastName", "Location", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("442da925-b4bc-41ba-b277-c8d0917595e1"), new DateOnly(1990, 1, 1), "Bachelor's Degree", "johndoe@example.com", "1 years as a Fontend Dev", "John", false, false, false, true, null, "Doe", "New York", "John123@doe", "+1 123-456-7890", "johndoe" },
                    { new Guid("7dad4995-c714-4094-9767-a49acdfe5b9f"), new DateOnly(2002, 1, 15), "Hue University", "nguyenthib123@gmail.com", "4 years as a Backend Developer", "B", false, false, false, false, null, "Nguyen Thi", "Hue, Viet Nam", "12345ThiB@", "086 3643 874", "nguyenthib123" },
                    { new Guid("b00943d6-a50c-4a53-9b01-8b3e46e68c15"), new DateOnly(2002, 1, 15), "Hue University", "nguyenvana@gmail.com", "3 years as a Backend Developer", "A", false, false, false, true, null, "Nguyen Van", "Hue, Viet Nam", "12345NguyenA@", "086 3458 471", "nguyena123" }
                });
        }
    }
}
