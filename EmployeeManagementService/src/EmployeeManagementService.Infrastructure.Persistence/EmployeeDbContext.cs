using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Domain.EmployeeTax;
using EmployeeManagementService.Domain.Tax;
using EmployeeManagementService.Infrastructure.Persistence;
using EmployeeManagementService.Infrastructure.Persistence.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementService.Infrastructure.persistence
{
    public class EmployeeDbContext(DbContextOptions<EmployeeDbContext> contextOptions) : DbContext(contextOptions){

        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Employee> Employees { get; set; }

        public DbSet<TaxInformation> TaxInformations { get; set; }

        public DbSet<TaxYear> TaxYears { get; set; }

        public DbSet<EmployeeTax> EmployeeTaxes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DbConstants.DefaultSchemaName);
            modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TaxInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TaxYearEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
        }
    }
}
