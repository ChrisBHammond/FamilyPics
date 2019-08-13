using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyPics.Models
{
    public class Context : DbContext
    { 
        public Context(DbContextOptions options)
            : base(options)
    {
    }
    
        public DbSet<Pic> Pics { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 1,
               UserName = "ChrisBHammond",
               FirstName = "Chris"
               
            }, new User
            {
                ID = 2,
                UserName = "BonnieBHammond",
                FirstName = "Bonnie"
            });

            
        }

    }
}
