using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; } //Read only 
        public IDepartmentRepository DepartmentRepository { get; } //Read only 
        int SaveChanges();
    }
}
