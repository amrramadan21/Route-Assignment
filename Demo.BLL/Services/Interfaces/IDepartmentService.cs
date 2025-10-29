using Demo.BLL.DTOs.DepartmentsDTOs;

namespace Demo.BLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        int AddDepartment(CreatedDepartmentDto departmentDto);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDto> GetAll();
        DepartmentDetailsDto? GetById(int id);
        int UpdateDepartment(UpdatedDepartmentDto departmentDto);
    }
}