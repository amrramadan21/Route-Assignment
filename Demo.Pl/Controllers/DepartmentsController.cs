using Demo.BLL.DTOs;
using Demo.BLL.Services;
using Demo.Pl.ViewModels.DepartmentViewModels;
using Microsoft.AspNetCore.Mvc;
namespace Demo.Pl.Controllers
{
    public class DepartmentsController(IDepartmentService _departmentService,ILogger<HomeController> logger,IWebHostEnvironment environment) : Controller
    {
        private readonly IDepartmentService departmentService = _departmentService;
        private readonly ILogger<HomeController> logger = logger;
        private readonly IWebHostEnvironment environment = environment;

        //Get BaseUrl/Departments/Index
        [HttpGet]
        public IActionResult Index()
        {
            var departments = departmentService.GetAll();
            return View(departments);
        }

        #region Create Department
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreatedDepartmentDto departmentDto) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int res = departmentService.AddDepartment(departmentDto);
                    if (res > 0) return RedirectToAction(nameof(Index));
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Departments Can't Be Added");
                        return View(departmentDto);
                    }
                }
                catch (Exception ex) 
                {
                    if (environment.IsDevelopment())
                    {
                        ModelState.AddModelError(string.Empty,ex.Message);
                        return View(departmentDto);
                    }
                    else
                    {
                        //logger.LogError(ex.Message);
                        return View(departmentDto);
                    }
                }
            }
            else return View(departmentDto);
        }
        #endregion


        #region Show Details
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var department = departmentService.GetById(id.Value);

            if (department is null) return NotFound();

            return View(department);
        }

        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if (!id.HasValue) return BadRequest();
            var department = departmentService.GetById(id.Value);
            if (department is null) return NotFound();

            var deptViewModel = new DepartmentEditViewModel()
            {
                Id = id.Value,
                name = department.Name,
                Code = department.Code,
                DateOfCreation = department.DateOfCreation,
                Description = department.Description,

            };
            return View(deptViewModel);
        }

        [HttpPost]
        public IActionResult Edit([FromRoute]int id ,DepartmentEditViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);
            try
            {
                var updateDeptDto = new UpdatedDepartmentDto()
                {
                    Id = id,
                    Code = viewModel.Code,
                    name = viewModel.name,
                    DateOfCreation = viewModel.DateOfCreation,
                    Description = viewModel.Description,
                };
                var res = departmentService.UpdateDepartment(updateDeptDto);
                if (res > 0 ) return RedirectToAction(nameof(Index));
                return View(viewModel);

            }
            catch (Exception ex)
            {
                if (environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View(viewModel);
                }
                else
                {
                    //logger.LogError(ex.Message);
                    return View(viewModel);
                }
            }
        }
        #endregion

        #region Delete

        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    if (!id.HasValue) return BadRequest();
        //    var dept =departmentService.GetById(id.Value);
        //    if (dept is null) return NotFound();
        //    return View(dept);

        //}

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();

            try
            {
                bool isDeleted = departmentService.DeleteDepartment(id);
                if (isDeleted)
                    return RedirectToAction(nameof(Index));
                else ModelState.AddModelError(string.Empty, "Department Can't Be Deleted");
                return RedirectToAction(nameof(Delete),new {id});
            }
            catch (Exception ex)
            {
                if (environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //logger.LogError(ex.Message);
                    return View("ErrorView",ex);
                }
            }

        }

        #endregion
    }
}
