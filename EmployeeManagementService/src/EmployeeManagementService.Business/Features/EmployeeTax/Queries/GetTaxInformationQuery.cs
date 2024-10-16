using EmployeeManagementService.Business.Features.Common.Requests;
using EmployeeManagementService.Business.Features.Common.Responses;
using EmployeeManagementService.Business.Features.EmployeeTax.Responses;
using MediatR;

namespace EmployeeManagementService.Business.Features.EmployeeTax.Queries
{
    public class GetTaxInformationQuery : IRequest<PaginatedResponse<TaxInformationResponse>>, IPaginatedRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
