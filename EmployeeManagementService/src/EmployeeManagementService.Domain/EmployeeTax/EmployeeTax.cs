using EmployeeManagementService.Domain.Common;
using EmployeeManagementService.Domain.Tax;

namespace EmployeeManagementService.Domain.EmployeeTax
{
    public class EmployeeTax : AuditableBaseEntity<int>
    {
        public int EmployeeId { get; set; }

        public Employee.Employee Employee { get; set; }

        public string TaxYearId { get; set; }

        public TaxYear TaxYear { get; set; }

        public string TaxInformationId { get; set; }

        public TaxInformation TaxInformation { get; set; }
    }
}
