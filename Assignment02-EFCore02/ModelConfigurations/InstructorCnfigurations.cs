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
    internal class InstructorCnfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I => I.Id);
            I.Property(I => I.Name).HasColumnName("Inst_Name").HasColumnType("varchar").HasMaxLength(50);
            I.Property(I => I.Bonus);
            I.Property(I => I.Address).IsRequired();
            I.Property(I => I.Salary);
            I.Property(I => I.HourRate);
            I.HasOne(I => I.WorkFor)
                .WithMany(D => D.Instructors)
                .HasForeignKey(D => D.WorkForId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
