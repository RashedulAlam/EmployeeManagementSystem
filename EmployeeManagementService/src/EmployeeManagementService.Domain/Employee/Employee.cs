using EmployeeManagementService.Domain.Common;

namespace EmployeeManagementService.Domain.Employee
{
    public class Employee : AuditableBaseEntity<int>
    {
        public const int EmailMaxLength = 320;
        public const int FirstNameMaxLength = 35;
        public const int LastNameMaxLength = 35;


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTimeOffset HireDate { get; set; }

        public string DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<EmployeeTax.EmployeeTax> EmployeeTaxes { get; set; }
    }
}
