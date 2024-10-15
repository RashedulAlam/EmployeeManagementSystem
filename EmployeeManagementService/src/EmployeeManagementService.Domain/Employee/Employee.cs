using EmployeeManagementService.Domain.Common;

namespace EmployeeManagementService.Domain.Employee
{
    public class Employee : AuditableBaseEntity<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string HireDate { get; set; }

        public string DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
