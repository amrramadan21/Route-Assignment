using Demo.BLL.DTOs;
using Demo.BLL.DTOs.EmployeeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetAll(string? EmployeeSearchName, bool withTraching = false);
        EmployeeDetailsDto? GetById(int id);
        int AddEmployee(CreateEmployeeDtos employeeDto);
        bool DeleteEmployee(int id);
        int UpdateEmployee(UpdateEmployeeDto employeeDto);

    }
}
