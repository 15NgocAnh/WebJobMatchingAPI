using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Data
{
    public class DBInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roles = new List<Roles>
                {
                    new Roles { Id = 1, Name = "ROLE_USER" },
                    new Roles { Id = 2, Name = "ROLE_ADMIN" }
                };

                var skills = new List<Skills>
                {
                    new Skills { Id = 1, Name = "BACKEND" },
                    new Skills { Id = 2, Name = "FONTEND" }
                };
                //var user_role = new List<User_Role>
                //{
                //    new User_Role { User_id = 1, Role_id = roles.First(r => r.Name == "ROLE_USER").Id },
                //    new User_Role { User_id = 2, Role_id = roles.First(r => r.Name == "ROLE_ADMIN").Id }
                //};

                var context = serviceScope.ServiceProvider.GetService<DBContext>();
                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new Entities.Users()
                        {
                            ID = Guid.NewGuid(),
                            FirstName = "John",
                            LastName = "Doe",
                            UserName = "johndoe",
                            Password = "password123",
                            Email = "johndoe@example.com",
                            BirthDay = new DateOnly(1990, 1, 1),
                            Education = "Bachelor's Degree",
                            Location = "New York",
                            Experience = "3 Years",
                            PhoneNumber = "+1 123-456-7890",
                            Skills = skills,
                            IsDeleted = false,
                            IsEmailConfirmed = false,
                            IsLocked = false,
                            IsMale = false,
                        },
                        new Entities.Users()
                        {
                            ID = Guid.NewGuid(),
                            FirstName = "John",
                            LastName = "Doe",
                            UserName = "johndoe",
                            Password = "password123",
                            Email = "johndoe@example.com",
                            BirthDay = new DateOnly(1990, 1, 1),
                            Education = "Bachelor's Degree in Computer Science",
                            Location = "New York, NY",
                            Experience = "3 years as a Backend Developer",
                            PhoneNumber = "+1-555-555-5555",
                            Skills = skills,
                            IsDeleted = false,
                            IsEmailConfirmed = false,
                            IsLocked = false,
                            IsMale = false,
                        });
                    context.SaveChanges();
                }
            }
        }

    }
}
