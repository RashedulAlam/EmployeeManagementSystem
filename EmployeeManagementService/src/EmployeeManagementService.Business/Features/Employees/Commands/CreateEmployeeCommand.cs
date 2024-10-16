using EmployeeManagementService.Business.Features.Employees.Responses;
using MediatR;

namespace EmployeeManagementService.Business.Features.Employees.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeResponse>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTimeOffset HireDate { get; set; }

        public string DepartmentId { get; set; }
    }
}
