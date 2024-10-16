using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementService.Models.Requests
{
    public class GetEmployeeRequest
    {
        [FromRoute]
        public int Id { get; set; }
    }
}
