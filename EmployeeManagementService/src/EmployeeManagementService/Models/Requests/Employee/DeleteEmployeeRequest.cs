using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementService.Models.Requests.Employee;

public class DeleteEmployeeRequest
{
    [FromRoute]
    public int Id { get; set; }
}