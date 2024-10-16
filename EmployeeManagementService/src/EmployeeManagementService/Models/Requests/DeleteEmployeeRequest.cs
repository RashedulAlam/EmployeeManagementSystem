using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementService.Models.Requests;

public class DeleteEmployeeRequest
{
    [FromRoute]
    public int Id { get; set; }
}