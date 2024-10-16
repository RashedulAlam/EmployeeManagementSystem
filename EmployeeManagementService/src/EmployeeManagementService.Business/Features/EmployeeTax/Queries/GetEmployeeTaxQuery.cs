using EmployeeManagementService.Business.Features.EmployeeTax.Responses;
using MediatR;

namespace EmployeeManagementService.Business.Features.EmployeeTax.Queries
{
    public class GetEmployeeTaxQuery : IRequest<IReadOnlyCollection<EmployeeTaxInformationResponse>>
    {
        public int EmployeeId { get; set; }
    }
}
