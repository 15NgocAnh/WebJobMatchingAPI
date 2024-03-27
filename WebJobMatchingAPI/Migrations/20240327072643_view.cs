using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebJobMatchingAPI.Migrations
{
    /// <inheritdoc />
    public partial class view : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" create view UsersViewModel as
                                SELECT UserName, Email, BirthDay, LastName + ' ' + FirstName as FullName, PhoneNumber, 
                                CASE 
                                    WHEN IsMale = 1 THEN 'Male' 
                                    ELSE 'Female' 
                                END as Gender
                                FROM dbo.users;
                ");
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                drop view UsersViewModel;
                ");
        }
    }
}
