using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore01.Models
{
    internal class Student // By Convension
    {
        public int Id { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public int Dept_Id { get; set; }


    }
}
