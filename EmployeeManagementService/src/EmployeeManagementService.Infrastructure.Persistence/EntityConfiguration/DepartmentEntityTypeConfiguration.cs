using EmployeeManagementService.Domain.Employee;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementService.Infrastructure.Persistence.EntityConfiguration
{
    public class DepartmentEntityTypeConfiguration : AuditableEntityTypeConfiguration<Department, string>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Department.NameMaxLength);

            builder.HasAlternateKey(x => x.Name);
        }
    }
}
