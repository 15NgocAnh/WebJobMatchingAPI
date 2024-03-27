using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebJobMatchingAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("20494a2f-1057-49ec-a109-2dd1fcba1d5f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("419a00f4-122e-42e8-b047-76be357e00cf"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("de03eb3f-3c46-41d5-b459-41484737056e"));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "ID", "BirthDay", "Education", "Email", "Experience", "FirstName", "IsDeleted", "IsEmailConfirmed", "IsLocked", "IsMale", "JobsId", "LastName", "Location", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("18319b6d-0948-43a0-b4f9-aed7d166eaae"), new DateOnly(2002, 1, 15), "Hue University", "nguyenvana@gmail.com", "3 years as a Backend Developer", "A", false, false, false, true, null, "Nguyen Van", "Hue, Viet Nam", "12345NguyenA@", "086 3458 471", "nguyena123" },
                    { new Guid("21fb9874-8cf9-4f20-b77c-0084f5ca98a3"), new DateOnly(1990, 1, 1), "Bachelor's Degree", "johndoe@example.com", "1 years as a Fontend Dev", "John", false, false, false, true, null, "Doe", "New York", "John123@doe", "+1 123-456-7890", "johndoe" },
                    { new Guid("b243f8c4-ffa0-4fc6-8402-a8daefcd736d"), new DateOnly(2002, 1, 15), "Hue University", "nguyenthib123@gmail.com", "4 years as a Backend Developer", "B", false, false, false, false, null, "Nguyen Thi", "Hue, Viet Nam", "12345ThiB@", "086 3643 874", "nguyenthib123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("18319b6d-0948-43a0-b4f9-aed7d166eaae"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("21fb9874-8cf9-4f20-b77c-0084f5ca98a3"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("b243f8c4-ffa0-4fc6-8402-a8daefcd736d"));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "ID", "BirthDay", "Education", "Email", "Experience", "FirstName", "IsDeleted", "IsEmailConfirmed", "IsLocked", "IsMale", "JobsId", "LastName", "Location", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("20494a2f-1057-49ec-a109-2dd1fcba1d5f"), new DateOnly(1990, 1, 1), "Bachelor's Degree", "johndoe@example.com", "1 years as a Fontend Dev", "John", false, false, false, true, null, "Doe", "New York", "John123@doe", "+1 123-456-7890", "johndoe" },
                    { new Guid("419a00f4-122e-42e8-b047-76be357e00cf"), new DateOnly(2002, 1, 15), "Hue University", "nguyenthib123@gmail.com", "4 years as a Backend Developer", "B", false, false, false, false, null, "Nguyen Thi", "Hue, Viet Nam", "12345ThiB@", "086 3643 874", "nguyenthib123" },
                    { new Guid("de03eb3f-3c46-41d5-b459-41484737056e"), new DateOnly(2002, 1, 15), "Hue University", "nguyenvana@gmail.com", "3 years as a Backend Developer", "A", false, false, false, true, null, "Nguyen Van", "Hue, Viet Nam", "12345NguyenA@", "086 3458 471", "nguyena123" }
                });
        }
    }
}
