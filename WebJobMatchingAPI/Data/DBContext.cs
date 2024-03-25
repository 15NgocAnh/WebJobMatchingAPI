using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
