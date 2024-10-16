using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementService.Models.Requests.TaxInformation
{
    public class EmployeeTaxInformationRequest
    {
        [FromRoute]
        public int Id { get; set; }
    }
}
