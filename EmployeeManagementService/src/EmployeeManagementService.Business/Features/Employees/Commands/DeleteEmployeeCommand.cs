using MediatR;

namespace EmployeeManagementService.Business.Features.Employees.Commands;

public class DeleteEmployeeCommand : IRequest
{
    public int EmployeeId { get; set; }
}