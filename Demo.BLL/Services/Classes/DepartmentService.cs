using Demo.BLL.DTOs.DepartmentsDTOs;
using Demo.BLL.Factories;
using Demo.BLL.Services.Interfaces;
using Demo.DAL.Repositories.Classes;
using Demo.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Classes
{
    public class DepartmentService:IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
        // Mapping
        // 1. Manual Mapping
        //    a. Constructor Mapping
        //    b. Extension Method
        // 2. Auto Mapping

        #region Manual Mapping

        // Get All Departments
        public IEnumerable<DepartmentDto> GetAll()
        {
            var depts = _unitOfWork.DepartmentRepository.GetAll();
            var departmentsToReturn = depts.Select(d => d.ToDepartmentDto()); // Extension Method
            return departmentsToReturn;
        }

        // Get Department By Id
        public DepartmentDetailsDto? GetById(int id)
        {
            var dept = _unitOfWork.DepartmentRepository.GetById(id);

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
        public int AddDepartment(CreatedDepartmentDto dto)
        {
             _unitOfWork.DepartmentRepository.Add(dto.ToEntity());
             return _unitOfWork.SaveChanges();
        }

        // Update Department
        public int UpdateDepartment(UpdatedDepartmentDto dto)
        {
            _unitOfWork.DepartmentRepository.Update(dto.ToEntity());
            return _unitOfWork.SaveChanges();

        }

        // Delete Department
        public bool DeleteDepartment(int id)
        {
            var department = _unitOfWork.DepartmentRepository.GetById(id);
            if (department is null) return false;

            //return _unitOfWork.SaveChanges();



            _unitOfWork.DepartmentRepository.Remove(department);
            return _unitOfWork.SaveChanges()> 0;
        }

        #endregion
    }
}
