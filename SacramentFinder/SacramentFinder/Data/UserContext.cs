using Microsoft.EntityFrameworkCore;
using SacramentFinder.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SacramentFinder.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(x => x.Username);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Users> Users { get; set; }
    }
}
