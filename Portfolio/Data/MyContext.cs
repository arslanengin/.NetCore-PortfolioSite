using Microsoft.EntityFrameworkCore;
using Portfolio.DomainClasses;
using Portfolio.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Portfolio.Data
{
    class MyContext : DbContext
    {
        public DbSet<Work> Works { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=PortfolyoDB;trusted_connection=true");
        }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new WorkMap());
            modelBuilder.ApplyConfiguration(new PhotoMap());

        }

    }
}