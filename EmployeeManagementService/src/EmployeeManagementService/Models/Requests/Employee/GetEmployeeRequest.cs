using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementService.Models.Requests.Employee
{
    public class GetEmployeeRequest
    {
        [FromRoute]
        public int Id { get; set; }
    }
}
