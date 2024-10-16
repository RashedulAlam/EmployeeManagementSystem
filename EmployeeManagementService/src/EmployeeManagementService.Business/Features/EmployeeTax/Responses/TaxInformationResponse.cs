namespace EmployeeManagementService.Business.Features.EmployeeTax.Responses
{
    public class TaxInformationResponse
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTimeOffset HireDate { get; set; }

        public string DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public DateTimeOffset EmployeeCreatedAt { get; set; }

        public DateTimeOffset EmployeeUpdatedAt { get; set; }

        public int TaxInformationId { get; set; }

        public string TaxYear { get; set; }

        public string TaxCode { get; set; }

        public decimal TaxRate { get; set; }

        public DateTimeOffset TaxInformationCreatedAt { get; set; }

        public DateTimeOffset TaxInformationUpdatedAt { get; set; }
    }
}
