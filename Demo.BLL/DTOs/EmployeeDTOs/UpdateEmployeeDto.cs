using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs.EmployeeDTOs
{
    public class UpdateEmployeeDto : CreateEmployeeDtos
    {
        public int Id { get; set; }
    }
}
