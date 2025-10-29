using AutoMapper;
using Demo.BLL.DTOs.EmployeeDTOs;
using Demo.BLL.Services.Interfaces;
using Demo.DAL.Data.Contexts;
using Demo.DAL.Models.EmployeeModel;
using Demo.DAL.Repositories.Classes;
using Demo.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Classes
{
    public class EmployeeService(IEmployeeRepository _employeeRepository,IMapper _mapper) : IEmployeeService
    {
        public IEnumerable<EmployeeDto> GetAll(bool withTraching = false)
        {
            var employees=_employeeRepository.GetAll();

            //var employeeDto = employees.Select(emp => new Employee()
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Age = emp.Age,
            //    Email = emp.Email,
            //    EmployeeType = emp.EmployeeType,
            //    Gender = emp.Gender,
            //    IsActive = emp.IsActive,
            //    Salary = emp.Salary,
            //});
            //return (IEnumerable<EmployeeDto>)employeeDto;
            var employeeDto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return employeeDto;
        }

        public EmployeeDetailsDto? GetById(int id)
        {
            var employee = _employeeRepository.GetById(id);
            if (employee == null) return null;
            return _mapper.Map<EmployeeDetailsDto>(employee);
        }


        public int AddEmployee(CreateEmployeeDtos dto)
        {
            var employee = _mapper.Map<Employee>(dto);
            return _employeeRepository.Add(employee);
        }
        public int UpdateEmployee(UpdateEmployeeDto dto)
        {
            var employee = _mapper.Map<Employee>(dto);
            return _employeeRepository.Update(employee);
        }

        public bool DeleteEmployee(int id)
        {
            var employee = _employeeRepository.GetById(id);
            if (employee is null) return false;
            else
            {
                employee.IsDeleted = true;
                return _employeeRepository.Update(employee)> 0 ? true :false;
            }
        }



    }
}
