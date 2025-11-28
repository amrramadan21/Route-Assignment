using Demo.DAL.Models.DepartmentModel;
namespace Demo.DAL.Data.Configurations
{
    public class DepartmentCnfiguration :BaseEntityConfiguration<Department> ,IEntityTypeConfiguration<Department>
    {
        public new void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10,10);
            builder.Property(D => D.Name).HasColumnType("varchar(20)");
            builder.Property(D => D.Code).HasColumnType("varchar(20)");
            builder.Property(D => D.Description).HasColumnType("varchar(200)");

            builder.HasMany(d=> d.Employees)
                   .WithOne(e=>e.Department)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.SetNull);


            base.Configure(builder);

        }
    }
}
