using Demo.BLL.DTOs;

namespace Demo.BLL.Services
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