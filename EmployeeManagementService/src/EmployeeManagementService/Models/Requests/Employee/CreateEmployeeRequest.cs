namespace EmployeeManagementService.Models.Requests.Employee
{
    public class CreateEmployeeRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTimeOffset HireDate { get; set; }

        public string DepartmentId { get; set; }
    }
}
