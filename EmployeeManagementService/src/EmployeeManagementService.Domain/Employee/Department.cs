using EmployeeManagementService.Domain.Common;

namespace EmployeeManagementService.Domain.Employee
{
    public class Department : AuditableBaseEntity<string>
    {
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
