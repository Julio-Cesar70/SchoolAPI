using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;

namespace School.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<Class> Class  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
