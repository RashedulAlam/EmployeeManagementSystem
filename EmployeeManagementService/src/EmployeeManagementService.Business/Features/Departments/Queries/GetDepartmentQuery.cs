using EmployeeManagementService.Business.Features.Departments.Responses;
using MediatR;

namespace EmployeeManagementService.Business.Features.Departments.Queries
{
    public sealed class GetDepartmentQuery : IRequest<DepartmentResponse>
    {
        public string Id { get; set; }
    }
}
