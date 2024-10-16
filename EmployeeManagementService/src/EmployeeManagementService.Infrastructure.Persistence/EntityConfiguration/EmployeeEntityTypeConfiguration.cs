using EmployeeManagementService.Domain.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementService.Infrastructure.Persistence.EntityConfiguration
{
    public class EmployeeEntityTypeConfiguration : AuditableEntityTypeConfiguration<Employee, int>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(Employee.EmailMaxLength);

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(Employee.FirstNameMaxLength);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(Employee.LastNameMaxLength);

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.HasOne(x => x.Department)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
