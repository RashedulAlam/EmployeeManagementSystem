using MediatR;

namespace EmployeeManagementService.Business.Features.Departments.Commands;

public class DeleteDepartmentCommand : IRequest
{
    public string Id { get; set; }
}