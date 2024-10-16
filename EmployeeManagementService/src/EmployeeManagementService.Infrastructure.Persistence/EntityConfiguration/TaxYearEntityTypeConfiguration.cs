using EmployeeManagementService.Domain.Tax;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementService.Infrastructure.Persistence.EntityConfiguration
{
    public class TaxYearEntityTypeConfiguration : AuditableEntityTypeConfiguration<TaxYear, string>
    {
        public override void Configure(EntityTypeBuilder<TaxYear> builder)
        {
            base.Configure(builder);

            // builder.Property(x => x.Id)
            //     .HasMaxLength(36);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(TaxYear.NameMaxLength);

            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
