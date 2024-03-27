using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebJobMatchingAPI.DTO;
using WebJobMatchingAPI.Entities;

namespace WebJobMatchingAPI.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WebJobMatchingAPI.Entities.Users> Users { get; set; } 
        public DbSet<WebJobMatchingAPI.Entities.Jobs> Jobs { get; set; } 
        public DbSet<WebJobMatchingAPI.Entities.Roles> Roles { get; set; }

        public DbSet<WebJobMatchingAPI.Entities.User_Role> User_Role { get; set; }
        public DbSet<WebJobMatchingAPI.Entities.Skills> Skills { get; set; }
        public DbSet<UsersViewModel> UsersViewModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasData(
                new Roles { Id = 1, Name = Role.ROLE_ADMIN },
                new Roles { Id = 2, Name = Role.ROLE_USER },
                new Roles { Id = 3, Name = Role.ROLE_GUEST }
            );
            modelBuilder.Entity<Skills>().HasData(
                new Skills { Id = 1, Name = "BACKEND" },
                new Skills { Id = 2, Name = "FONTEND" }
            );
            modelBuilder.Entity<Users>().HasData(
                new Users() {
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
            //modelBuilder.Entity<User_Role>.HasData(
            //    new User_Role() { i}
            //);

            modelBuilder
                .Entity<UsersViewModel>()
                .ToView(nameof(UsersViewModel)).HasNoKey();

            modelBuilder.Entity<Jobs>(u =>
            {
                u.ToTable("jobs");
                u.HasKey(j => j.Id);
                u.Property(d => d.Created).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<Users>(u =>
            {
                u.HasIndex(e => e.Email).IsUnique();
                u.HasIndex(u => u.UserName).IsUnique();
            });

            modelBuilder.Entity<User_Role>(ur =>
            {
                ur.ToTable("user_role");
                ur.HasKey(k => new { k.User_id, k.Role_id });

                ur.HasOne(e => e.user)
                    .WithMany(e => e.Roles)
                    .HasForeignKey(e => e.User_id)
                    .HasConstraintName("FK_User");

                ur.HasOne(e => e.role)
                    .WithMany(e => e.Users)
                    .HasForeignKey(e => e.Role_id)
                    .HasConstraintName("FK_Role");
            });
        }
    }
}
