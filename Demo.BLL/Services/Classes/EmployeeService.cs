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
    public class EmployeeService(IUnitOfWork unitOfWork,IMapper _mapper) : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public IEnumerable<EmployeeDto> GetAll(string? EmployeeSearchName, bool withTraching = false)
        {

            //var employees = _unitOfWork.EmployeeRepository.GetAll(e=> e.Name.ToLower().Contains(EmployeeSearchName.ToLower()));
            //return _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(employees);


            IEnumerable<Employee> employees;
            if(string.IsNullOrWhiteSpace(EmployeeSearchName))
                employees = _unitOfWork.EmployeeRepository.GetAll();
            else
                employees = _unitOfWork.EmployeeRepository.GetAll(e => e.Name.ToLower().Contains(EmployeeSearchName.ToLower()));

            return _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(employees);

            #region IEnumrable

            //var result = _unitOfWork.EmployeeRepository.GetIEnumerable()
            //                                .Where(e => e.IsDeleted == false)
            //                                .Select(e => new EmployeeDto()
            //                                {
            //                                    Id = e.Id,
            //                                    Name = e.Name,
            //                                    Age = e.Age
            //      
            #endregion                           });

            #region IQueryable
            //var result = _unitOfWork.EmployeeRepository.GetIQueryable()
            //                                   .Where(e => e.IsDeleted == false)
            //                                   .Select(e => new EmployeeDto()
            //                                   {
            //                                       Id = e.Id,
            //                                       Name = e.Name,
            //                                       Age = e.Age
            //                                   }); 
            #endregion
        }

        public EmployeeDetailsDto? GetById(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.GetById(id);
            if (employee == null) return null;
            return _mapper.Map<EmployeeDetailsDto>(employee);
        }


        public int AddEmployee(CreateEmployeeDtos dto)
        {
            var employee = _mapper.Map<Employee>(dto);
             _unitOfWork.EmployeeRepository.Add(employee);
            return _unitOfWork.SaveChanges();

        }
        public int UpdateEmployee(UpdateEmployeeDto dto)
        {
            var employee = _mapper.Map<Employee>(dto);
            _unitOfWork.EmployeeRepository.Update(employee);
            return _unitOfWork.SaveChanges();

        }

        public bool DeleteEmployee(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.GetById(id);
            if (employee is null) return false;
            else
            {
                employee.IsDeleted = true;
                _unitOfWork.EmployeeRepository.Update(employee);
                return _unitOfWork.SaveChanges() > 0 ? true :false;
            }
        }



    }
}
