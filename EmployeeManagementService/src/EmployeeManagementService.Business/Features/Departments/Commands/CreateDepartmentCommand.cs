using EmployeeManagementService.Business.Features.Departments.Responses;
using MediatR;

namespace EmployeeManagementService.Business.Features.Departments.Commands
{
    public class CreateDepartmentCommand : IRequest<DepartmentResponse>
    {
        public string Name { get; set; }
    }
}
