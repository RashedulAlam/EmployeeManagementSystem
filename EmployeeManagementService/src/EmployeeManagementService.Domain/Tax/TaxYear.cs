using EmployeeManagementService.Domain.Common;

namespace EmployeeManagementService.Domain.Tax
{
    public class TaxYear : AuditableBaseEntity<string>
    {
        public const int NameMaxLength = 220;

        public string Name { get; set; }

        public ICollection<EmployeeTax.EmployeeTax> EmployeeTaxes { get; set; }
    }
}
