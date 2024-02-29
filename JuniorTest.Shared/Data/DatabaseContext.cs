using JuniorTest.Shared.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JuniorTest.Shared.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Material> Materials { get; set; }
    }
}


