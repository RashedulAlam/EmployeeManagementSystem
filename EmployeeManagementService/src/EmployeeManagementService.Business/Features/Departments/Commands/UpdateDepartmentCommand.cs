using EmployeeManagementService.Business.Features.Departments.Responses;
using MediatR;

namespace EmployeeManagementService.Business.Features.Departments.Commands;

public class UpdateDepartmentCommand : IRequest<DepartmentResponse>
{
    public string Id { get; set; }

    public string Name { get; set; }
}