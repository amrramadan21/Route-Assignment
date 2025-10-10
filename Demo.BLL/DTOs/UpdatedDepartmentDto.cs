using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs
{
    public class UpdatedDepartmentDto : CreatedDepartmentDto
    {
        public int Id { get; set; }
    }
}
