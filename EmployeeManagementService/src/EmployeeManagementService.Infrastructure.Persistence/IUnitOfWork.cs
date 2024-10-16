using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence.Repositories;

namespace EmployeeManagementService.Infrastructure.Persistence
{
    public interface IUnitOfWork
    {
        public IGenericRepository<Employee, int> EmployeeRepository { get;}
        public IGenericRepository<Department, string> DepartmentRepository { get;}
        public Task SaveChanges();
    }
}
