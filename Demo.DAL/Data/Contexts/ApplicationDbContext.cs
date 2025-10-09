using Demo.DAL.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Data.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        private Assembly Assembly;


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("ConnectionString");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Department>(new DepartmentCnfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Department> Departments { get; set; } 
    }
}
