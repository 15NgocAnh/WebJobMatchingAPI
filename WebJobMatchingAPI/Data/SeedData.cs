using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Data
{
    public class SeedData
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using(var context = new DBContext(serviceProvider.GetRequiredService<DbContextOptions<DBContext>>()))
            {
                var users = new List<Users>()
                {
                    new Users()
                    {
  
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
                };
                if (!context.Users.Any()) {context.Users.AddRange(users); }

                var roles = new List<Roles>()
                {
                    new Roles {Name = Role.ROLE_ADMIN },
                    new Roles { Name = Role.ROLE_USER },
                    new Roles { Name = Role.ROLE_GUEST }
                };
                if (!context.Roles.Any()) {context.Roles.AddRange(roles); }

                var skills = new List<Skills>()
                {
                    new Skills { Name = "BACKEND" },
                    new Skills { Name = "FONTEND" }
                };
                if (!context.Skills.Any()) { context.Skills.AddRange(skills); }

                context.SaveChanges();
            }
        }
    }
}
