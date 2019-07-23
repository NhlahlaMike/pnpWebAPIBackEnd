using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pnpWebAPIBackEnd.Models
{
    public class UsersContext: DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*builder.Entity<Users>()
                .HasIndex(u => u.Email)
                .IsUnique();*/
        }

        public virtual DbSet<Users> UsersDetails { get; set; }
    }
}
