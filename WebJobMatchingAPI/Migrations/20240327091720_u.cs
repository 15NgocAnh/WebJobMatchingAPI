using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebJobMatchingAPI.Migrations
{
    /// <inheritdoc />
    public partial class u : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("629fb61b-faad-471c-a3dc-329bb1e7c6d0"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("b90f48b3-8a17-4563-8779-0e45e32bbd45"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("e1e8c073-2234-4b51-8ea4-4c0f8b85c38d"));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "ID", "BirthDay", "Education", "Email", "Experience", "FirstName", "IsDeleted", "IsEmailConfirmed", "IsLocked", "IsMale", "JobsId", "LastName", "Location", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("2570645d-ca3a-4922-a194-95d12030ecfc"), new DateOnly(2002, 1, 15), "Hue University", "nguyenvana@gmail.com", "3 years as a Backend Developer", "A", false, false, false, true, null, "Nguyen Van", "Hue, Viet Nam", "12345NguyenA@", "086 3458 471", "nguyena123" },
                    { new Guid("91e0d5bd-87c9-4817-b978-e6af904b01b6"), new DateOnly(1990, 1, 1), "Bachelor's Degree", "johndoe@example.com", "1 years as a Fontend Dev", "John", false, false, false, true, null, "Doe", "New York", "John123@doe", "+1 123-456-7890", "johndoe" },
                    { new Guid("d3372ccd-298c-4fd8-9aed-745c61d85264"), new DateOnly(2002, 1, 15), "Hue University", "nguyenthib123@gmail.com", "4 years as a Backend Developer", "B", false, false, false, false, null, "Nguyen Thi", "Hue, Viet Nam", "12345ThiB@", "086 3643 874", "nguyenthib123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("2570645d-ca3a-4922-a194-95d12030ecfc"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("91e0d5bd-87c9-4817-b978-e6af904b01b6"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "ID",
                keyValue: new Guid("d3372ccd-298c-4fd8-9aed-745c61d85264"));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "ID", "BirthDay", "Education", "Email", "Experience", "FirstName", "IsDeleted", "IsEmailConfirmed", "IsLocked", "IsMale", "JobsId", "LastName", "Location", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("629fb61b-faad-471c-a3dc-329bb1e7c6d0"), new DateOnly(2002, 1, 15), "Hue University", "nguyenthib123@gmail.com", "4 years as a Backend Developer", "B", false, false, false, false, null, "Nguyen Thi", "Hue, Viet Nam", "12345ThiB@", "086 3643 874", "nguyenthib123" },
                    { new Guid("b90f48b3-8a17-4563-8779-0e45e32bbd45"), new DateOnly(2002, 1, 15), "Hue University", "nguyenvana@gmail.com", "3 years as a Backend Developer", "A", false, false, false, true, null, "Nguyen Van", "Hue, Viet Nam", "12345NguyenA@", "086 3458 471", "nguyena123" },
                    { new Guid("e1e8c073-2234-4b51-8ea4-4c0f8b85c38d"), new DateOnly(1990, 1, 1), "Bachelor's Degree", "johndoe@example.com", "1 years as a Fontend Dev", "John", false, false, false, true, null, "Doe", "New York", "John123@doe", "+1 123-456-7890", "johndoe" }
                });
        }
    }
}
