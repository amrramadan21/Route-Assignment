using Demo.DAL.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories
{
    internal class DepartmentRepository(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        //CRUD
        //Get Department By Id
        public Department? GetById(int id)
        {
            var department = _context.Departments.Find(id);
            return department;
        }
        //Get All Departments
        //Add Department
        //Update Department
        //Delete Department
    }
}
