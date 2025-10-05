using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore01.Models
{
    internal class Course_Inst //By Fluents API [OnModelCreating]
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string? Evaluation { get; set; }
    }
}
