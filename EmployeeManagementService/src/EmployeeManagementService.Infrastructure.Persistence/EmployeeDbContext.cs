using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementService.Infrastructure.persistence
{
    public class EmployeeDbContext(DbContextOptions<EmployeeDbContext> contextOptions) : DbContext(contextOptions){

        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentEntityTypeConfiguration());
        }
    }
}
