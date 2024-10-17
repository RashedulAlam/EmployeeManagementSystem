using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Domain.EmployeeTax;
using EmployeeManagementService.Domain.Tax;
using EmployeeManagementService.Infrastructure.Persistence.Repositories;

namespace EmployeeManagementService.Infrastructure.Persistence
{
    public interface IUnitOfWork
    {
        public IGenericRepository<Employee, int> EmployeeRepository { get;}
        public IGenericRepository<Department, string> DepartmentRepository { get;}
        public IGenericRepository<TaxYear, string> TaxYearRepository { get;}
        public IGenericRepository<TaxInformation, string> TaxInformationRepository { get; }
        public IGenericRepository<EmployeeTax, int> EmployeeTax { get; }

        public Task SaveChanges();
    }
}
