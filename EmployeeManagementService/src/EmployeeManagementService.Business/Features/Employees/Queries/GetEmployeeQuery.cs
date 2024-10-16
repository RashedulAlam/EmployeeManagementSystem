using EmployeeManagementService.Business.Features.Employees.Responses;
using MediatR;

namespace EmployeeManagementService.Business.Features.Employees.Queries
{
    public class GetEmployeeQuery : IRequest<EmployeeResponse>
    {
        public int Id { get; set; }
    }
}
