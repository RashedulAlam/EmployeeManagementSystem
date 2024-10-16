namespace EmployeeManagementService.Infrastructure.External.Responses
{
    public class TaxInformationResponse
    {
        public int TaxYear { get; set; }

        public string TaxCode { get; set; }

        public decimal TaxRate { get; set; }
    }
}
