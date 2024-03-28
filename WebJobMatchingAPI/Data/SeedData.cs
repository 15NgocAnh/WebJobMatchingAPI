using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Data
{
    public class SeedData
    {
        private static readonly DBContext context;

        public static void Seed(ModelBuilder modelBuilder)
        {

            if (!context.Users.Any())
            {
                modelBuilder.Entity<Users>().HasData(
                    new Users()
                    {
                        ID = Guid.NewGuid(),
                        FirstName = "John",
                        LastName = "Doe",
                        UserName = "johndoe",
                        Password = "John123@doe",
                        Email = "johndoe@example.com",
                        BirthDay = new DateOnly(1990, 1, 1),
                        Education = "Bachelor's Degree",
                        Location = "New York",
                        Experience = "1 years as a Fontend Dev",
                        PhoneNumber = "+1 123-456-7890",
                        Skills = null,
                        IsDeleted = false,
                        IsEmailConfirmed = false,
                        IsLocked = false,
                        IsMale = true,
                        Roles = null
                    },
                    new Users()
                    {
                        ID = Guid.NewGuid(),
                        FirstName = "A",
                        LastName = "Nguyen Van",
                        UserName = "nguyena123",
                        Password = "12345NguyenA@",
                        Email = "nguyenvana@gmail.com",
                        BirthDay = new DateOnly(2002, 1, 15),
                        Education = "Hue University",
                        Location = "Hue, Viet Nam",
                        Experience = "3 years as a Backend Developer",
                        PhoneNumber = "086 3458 471",
                        Skills = null,
                        IsDeleted = false,
                        IsEmailConfirmed = false,
                        IsLocked = false,
                        IsMale = true,
                        Roles = null
                    },
                    new Users()
                    {
                        ID = Guid.NewGuid(),
                        FirstName = "B",
                        LastName = "Nguyen Thi",
                        UserName = "nguyenthib123",
                        Password = "12345ThiB@",
                        Email = "nguyenthib123@gmail.com",
                        BirthDay = new DateOnly(2002, 1, 15),
                        Education = "Hue University",
                        Location = "Hue, Viet Nam",
                        Experience = "4 years as a Backend Developer",
                        PhoneNumber = "086 3643 874",
                        Skills = null,
                        IsDeleted = false,
                        IsEmailConfirmed = false,
                        IsLocked = false,
                        IsMale = false,
                        Roles = null
                    }
                );
            }

            if (!context.Roles.Any())
            {
                modelBuilder.Entity<Roles>().HasData(
                    new Roles { Id = 1, Name = Role.ROLE_ADMIN },
                    new Roles { Id = 2, Name = Role.ROLE_USER },
                    new Roles { Id = 3, Name = Role.ROLE_GUEST }
                );
            }

            if (!context.Skills.Any())
            {
                modelBuilder.Entity<Skills>().HasData(
                    new Skills { Id = 1, Name = "BACKEND" },
                    new Skills { Id = 2, Name = "FONTEND" }
                );
            }
        }
    }
}
