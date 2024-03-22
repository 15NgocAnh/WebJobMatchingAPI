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

        public DbSet<WebJobMatchingAPI.Entities.Users> Users { get; set; } = default!;
        public DbSet<WebJobMatchingAPI.Entities.Jobs> Jobs { get; set; } = default!;
        public DbSet<WebJobMatchingAPI.Entities.Roles> Roles { get; set; } = default!;
    }
}
