using Assignment01_EFCore01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EFCore01.ModelConfigurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.Id);
            D.Property(D => D.Name).HasColumnName("Dept_Name").HasColumnType("varchar").HasMaxLength(50);
            D.Property(D => D.Inst_Id).IsRequired();
            D.Property(D => D.HiringDate);
        }
    }
}
