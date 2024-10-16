using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.persistence;
using EmployeeManagementService.Infrastructure.Persistence.Repositories;

namespace EmployeeManagementService.Infrastructure.Persistence;

public class UnitOfWork(EmployeeDbContext employeeDbContext) : IUnitOfWork, IDisposable
{
    public IGenericRepository<Employee, int> EmployeeRepository => new GenericRepository<Employee, int>(employeeDbContext);

    public IGenericRepository<Department, string> DepartmentRepository =>
        new GenericRepository<Department, string>(employeeDbContext);


    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (employeeDbContext != null)
            {
                employeeDbContext.Dispose();
                employeeDbContext = null;
            }
        }
    }
}