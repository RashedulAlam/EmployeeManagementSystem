using EmployeeManagementService.Domain.EmployeeTax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementService.Infrastructure.Persistence.EntityConfiguration
{
    public class EmployeeTaxEntityTypeConfiguration : AuditableEntityTypeConfiguration<EmployeeTax, int>
    {
        public override void Configure(EntityTypeBuilder<EmployeeTax> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.TaxYear)
                .WithMany(x => x.EmployeeTaxes)
                .HasForeignKey(x => x.TaxYearId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TaxInformation)
                .WithMany(x => x.EmployeeTaxes)
                .HasForeignKey(x => x.TaxInformationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.EmployeeTaxes)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => new { x.EmployeeId, x.TaxInformationId, x.TaxYearId })
                .IsUnique();
        }
    }
}
