using Assignment01_EFCore01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore01.DataBaseContexts
{
    internal class ITIV01 : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; DataBase = ITIV01; Trusted_Connection = true ;TrustServerCertificate = true");
        }

        #region DbSets
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<StudentCourse> Student_Course { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

        public DbSet<Topic> Topics { get; set; }
        #endregion

        #region Create DataBase By fluent API [OnModelCreating]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentCourse>( SC =>
            {
                SC.HasKey(S => new {S.Stud_Id,S.Course_Id});
                SC.Property(S => S.Grade)
                .IsRequired();
            });

            modelBuilder.Entity<Course_Inst>(CI =>
            {
                CI.HasKey(C => new {C.Course_Id,C.Inst_Id});
                CI.Property(C => C.Evaluation).HasMaxLength(50).IsRequired(false);

            });
            
        } 
        #endregion


    }
}
