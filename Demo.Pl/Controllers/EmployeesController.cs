using Demo.BLL.DTOs.DepartmentsDTOs;
using Demo.BLL.DTOs.EmployeeDTOs;
using Demo.BLL.Services.Classes;
using Demo.BLL.Services.Interfaces;
using Demo.DAL.Models.EmployeeModel;
using Demo.DAL.Models.Shared.Enums;
using Demo.Pl.ViewModels.EmployeeViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Demo.Pl.Controllers
{
    public class EmployeesController(IEmployeeService _employeeService,
                                     IWebHostEnvironment environment
                                    ) : Controller
    {
        public IActionResult Index()
        {
            var employees = _employeeService.GetAll();
            return View(employees);
        }

        #region Create
        [HttpGet]
        public IActionResult Create(/*[FromServices] IDepartmentService _departmentService*/)
        {
            //ViewData["Departments"] = _departmentService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var dto =new CreateEmployeeDtos()
                    {
                        Name = model.Name,
                        Email = model.Email,
                        Age = model.Age,
                        Address = model.Address,
                        DepartmentId = model.DepartmentId,
                        EmployeeType = model.EmployeeType,
                        Gender = model.Gender,
                        HiringDate = model.HiringDate,
                        IsActive = model.IsActive,
                        PhoneNumber = model.PhoneNumber,
                        Salary = model.Salary

                    };
                    int res = _employeeService.AddEmployee(dto);
                    if (res > 0) return RedirectToAction(nameof(Index));
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Employee Can't Be Added");
                        return View(model);
                    }
                }
                catch (Exception ex)
                {
                    if (environment.IsDevelopment())
                    {
                        ModelState.AddModelError(string.Empty, ex.Message);
                        return View(model);
                    }
                    else
                    {
                        //logger.LogError(ex.Message);
                        return View(model);
                    }
                }
            }
            else return View(model);

        }

        #endregion

        #region Details

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var emp = _employeeService.GetById(id.Value);

            if (emp is null) return NotFound();

            return View(emp);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {

            if (!id.HasValue) return BadRequest();
            var emp = _employeeService.GetById(id.Value);

            if (emp is null) return NotFound();
            var dto = new EmployeeViewModel()
            {
                Name = emp.Name,
                Age=emp.Age,
                Address=emp.Address,
                Email=emp.Email,
                PhoneNumber=emp.PhoneNumber,
                Salary=emp.Salary,
                HiringDate=emp.HiringDate,
                IsActive=emp.IsActive,
                EmployeeType=Enum.Parse<EmployeeType>(emp.EmployeeType),
                Gender=Enum.Parse<Gender>(emp.Gender),
                DepartmentId = emp.DepartmentId
            };

            return View(dto);
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int id,EmployeeViewModel model)
        {


            if (!ModelState.IsValid) return View(model);
            try
            {
                var dto = new UpdateEmployeeDto()
                {
                    Id =id,
                    Name = model.Name,
                    Email = model.Email,
                    Age = model.Age,
                    Address = model.Address,
                    DepartmentId = model.DepartmentId,
                    EmployeeType = model.EmployeeType,
                    Gender = model.Gender,
                    HiringDate = model.HiringDate,
                    IsActive = model.IsActive,
                    PhoneNumber = model.PhoneNumber,
                    Salary = model.Salary

                };

                var res = _employeeService.UpdateEmployee(dto);
                if (res > 0) return RedirectToAction(nameof(Index));
                return View(dto);

            }
            catch (Exception ex)
            {
                if (environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View(model);
                }
                else
                {
                    //logger.LogError(ex.Message);
                    return View(model);
                }
            }

        }
        #endregion

        #region Delete
        [HttpPost]
        public IActionResult Delete([FromRoute] int id)
        {
            if (id == 0) return BadRequest();

            try
            {
                bool isDeleted = _employeeService.DeleteEmployee(id);
                if (isDeleted)
                    return RedirectToAction(nameof(Index));
                else ModelState.AddModelError(string.Empty, "Employee Can't Be Deleted");
                return RedirectToAction(nameof(Delete), new { id });
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
                    return View("ErrorView", ex);
                }
            }

        }
        #endregion
    }
}
