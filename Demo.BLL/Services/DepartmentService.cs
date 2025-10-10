using Demo.BLL.DTOs;
using Demo.BLL.Factories;
using Demo.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services
{
    public class DepartmentService(IDepartmentRepository _departmentRepository) : IDepartmentService
    {
        // Mapping
        // 1. Manual Mapping
        //    a. Constructor Mapping
        //    b. Extension Method
        // 2. Auto Mapping

        #region Manual Mapping

        // Get All Departments
        public IEnumerable<DepartmentDto> GetAll()
        {
            var depts = _departmentRepository.GetAll();
            var departmentsToReturn = depts.Select(d => d.ToDepartmentDto()); // Extension Method
            return departmentsToReturn;
        }

        // Get Department By Id
        public DepartmentDetailsDto? GetById(int id)
        {
            var dept = _departmentRepository.GetById(id);

            #region Old Way of Manual Mapping

            // if (dept is null) return null;
            // else
            // {
            //     var deptToReturn = new DepartmentDetailsDto()
            //     {
            //         Id = dept.Id,
            //         Name = dept.Name,
            //         Code = dept.Code,
            //         CreatedBy = dept.CreatedBy,
            //         LastModifiedBy = dept.LastModifiedBy,
            //         IsDeleted = dept.IsDeleted,
            //         DateOfCreation = DateOnly.FromDateTime(dept.CreatedOn),
            //         LastModifiedOn = DateOnly.FromDateTime(dept.LastModifiedOn)
            //     };
            //     return deptToReturn;
            // }

            // return dept == null ? null : new DepartmentDetailsDto()
            // {
            //     Id = dept.Id,
            //     Name = dept.Name,
            //     Code = dept.Code,
            //     CreatedBy = dept.CreatedBy,
            //     LastModifiedBy = dept.LastModifiedBy,
            //     IsDeleted = dept.IsDeleted,
            //     DateOfCreation = DateOnly.FromDateTime(dept.CreatedOn),
            //     LastModifiedOn = DateOnly.FromDateTime(dept.LastModifiedOn)
            // };

            #endregion

            // return dept == null ? null : new DepartmentDetailsDto(dept); // Constructor Mapping
            return dept == null ? null : dept.ToDepartmentDetailsDto(); // Extension Method Mapping
        }

        // Create Department
        public int AddDepartment(CreatedDepartmentDto departmentDto)
        {
            var entity = departmentDto.ToEntity();
            return _departmentRepository.Add(entity);
        }

        // Update Department
        public int UpdateDepartment(UpdatedDepartmentDto departmentDto)
        {
            var entity = departmentDto.ToEntity();
            return _departmentRepository.Update(entity);
        }

        // Delete Department
        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department is null) return false;

            var res = _departmentRepository.Remove(department);
            return res > 0;
        }

        #endregion
    }
}
