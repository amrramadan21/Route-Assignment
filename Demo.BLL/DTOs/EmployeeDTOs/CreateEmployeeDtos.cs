using Demo.DAL.Models.EmployeeModel;
using Demo.DAL.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs.EmployeeDTOs
{
    public class CreateEmployeeDtos
    {
        [Required]
        [MaxLength(50,ErrorMessage ="Max Lenght Should Be 50 Character")]
        [MinLength(5, ErrorMessage = "Max Lenght Should Be 5 Character")]
        public string Name { get; set; }

        [Range(22,30)]
        public int? Age { get; set; }

        [RegularExpression("^[1-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[A-zA-Z]{5,10}$",
            ErrorMessage ="Adress Must Be Like 123-Street-City-Country")]
        public string? Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name ="Is Active")]
        public bool IsActive { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Display(Name ="Phone Number")]
        [Phone]
        public string? PhoneNumber { get; set; }

        [Display(Name ="Hiring Date")]
        public DateOnly HiringDate { get; set; }

        public Gender Gender { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public int? DepartmentId { get; set; }
    }
}
