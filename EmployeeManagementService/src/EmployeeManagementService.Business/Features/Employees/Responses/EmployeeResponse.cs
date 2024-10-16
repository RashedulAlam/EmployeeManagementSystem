namespace EmployeeManagementService.Business.Features.Employees.Responses
{
    public class EmployeeResponse
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTimeOffset HireDate { get; set; }

        public string DepartmentId { get; set; }

        public string DepartmentName { get; set; }
    }
}
