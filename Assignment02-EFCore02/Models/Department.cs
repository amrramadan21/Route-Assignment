using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore01.Models
{
    internal class Department //By Flent API [IEntityTypeCnofigration]
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Inst_Id { get; set; }

        public DateTime HiringDate { get; set; }
        public List<Instructor> Instructors { get; set; }


    }
}
