using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.persistence;
using EmployeeManagementService.Infrastructure.Persistence.Repositories;

namespace EmployeeManagementService.Infrastructure.Persistence;

public class UnitOfWork(EmployeeDbContext employeeDbContext) : IUnitOfWork, IDisposable, IAsyncDisposable
{
    public IGenericRepository<Employee, int> EmployeeRepository => new GenericRepository<Employee, int>(employeeDbContext);

    public IGenericRepository<Department, string> DepartmentRepository =>
        new GenericRepository<Department, string>(employeeDbContext);

    public void Dispose()
    {
        employeeDbContext?.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        if (employeeDbContext != null) await employeeDbContext.DisposeAsync();
    }
}