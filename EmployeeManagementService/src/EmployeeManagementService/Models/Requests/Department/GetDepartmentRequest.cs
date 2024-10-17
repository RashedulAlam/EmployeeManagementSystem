using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementService.Models.Requests.Department
{
    public class GetDepartmentRequest
    {
        [FromRoute]
        public string Id { get; set; }
    }
}
