using System;
using Microsoft.EntityFrameworkCore;
using Gil.ApiDotNet7.Domain.Entities;
namespace Gil.ApiDotNet7.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        /* The entity required be mapped. 
           If the name of properties from entity are different than properties from database
           Is necessary use Maps to map
        */
        public DbSet<Person> People { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
        
    }
}
