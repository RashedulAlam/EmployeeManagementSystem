using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementService.Models.Requests;

public class UpdateEmployeeRequest
{
    [FromRoute]
    public int Id { get; set; }

    [FromBody]
    public string FirstName { get; set; }

    [FromBody]
    public string LastName { get; set; }

    [FromBody]
    public string Email { get; set; }

    [FromBody]
    public DateTimeOffset HireDate { get; set; }

    [FromBody]
    public string DepartmentId { get; set; }
}