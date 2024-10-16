using EmployeeManagementService.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementService.Infrastructure.Persistence.EntityConfiguration
{
    public class AuditableEntityTypeConfiguration<T,TU> : IEntityTypeConfiguration<T> where T : AuditableBaseEntity<TU>
    {
        private const int UserNameMaxLength = 320;
        protected const int StingIdMaxLength = 36;

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(StingIdMaxLength)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedBy)
                .IsRequired()
                .HasMaxLength(UserNameMaxLength);

            builder.Property(x => x.LastModifiedBy)
                .IsRequired()
                .HasMaxLength(UserNameMaxLength);

            builder.Property(x => x.CreatedAt)
                .IsRequired()
                .HasDefaultValue(DateTimeOffset.UtcNow);

            builder.Property(x => x.LastModifiedAt)
                .IsRequired()
                .HasDefaultValue(DateTimeOffset.UtcNow);

        }
    }
}
