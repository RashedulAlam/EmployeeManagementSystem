using EmployeeManagementService.Domain.Common;

namespace EmployeeManagementService.Domain.Tax
{
    public class TaxInformation : AuditableBaseEntity<string>
    {
        public const int CodeMaxLength = 220;

        public string Code { get; set; }

        public decimal Rate { get; set; }

        public ICollection<EmployeeTax.EmployeeTax> EmployeeTaxes { get; set; }
    }
}
