using EmployeeManagementService.Domain.Tax;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementService.Infrastructure.Persistence.EntityConfiguration
{
    public class TaxInformationEntityTypeConfiguration : AuditableEntityTypeConfiguration<TaxInformation, string>
    {
        public override void Configure(EntityTypeBuilder<TaxInformation> builder)
        {
            base.Configure(builder);

            // builder.Property(x => x.Id)
            //     .HasMaxLength(StingIdMaxLength);

            builder.Property(x => x.Id)
                .HasMaxLength(36);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(TaxInformation.CodeMaxLength);

            builder.Property(x => x.Rate)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.HasIndex(x => x.Code)
                .IsUnique();
        }
    }
}
