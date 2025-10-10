using Demo.BLL.Services;
using Microsoft.AspNetCore.Mvc;
namespace Demo.Pl.Controllers
{
    public class DepartmentsController(IDepartmentService _departmentService) : Controller
    {
        //Get BaseUrl/Departments/Index
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentService.GetAll();
            return View(departments);
        }
    }
}
