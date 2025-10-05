using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore01.Models
{
    internal class StudentCourse //By Fluents API [OnModelCreating]
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public double Grade {  get; set; }
    }
}
