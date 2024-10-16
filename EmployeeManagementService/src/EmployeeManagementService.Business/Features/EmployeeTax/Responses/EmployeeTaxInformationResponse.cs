namespace EmployeeManagementService.Business.Features.EmployeeTax.Responses
{
    public class EmployeeTaxInformationResponse
    {
        public int Id { get; set; }

        public string TaxYear { get; set; }

        public string TaxCode { get; set; }

        public decimal TaxRate { get; set; }
    }
}
