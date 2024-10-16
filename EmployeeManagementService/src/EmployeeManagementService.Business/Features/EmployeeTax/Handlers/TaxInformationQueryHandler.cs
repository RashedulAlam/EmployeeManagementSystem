using AutoMapper;
using EmployeeManagementService.Business.Features.Common.Responses;
using EmployeeManagementService.Business.Features.EmployeeTax.Queries;
using EmployeeManagementService.Business.Features.EmployeeTax.Responses;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.EmployeeTax.Handlers
{
    public class TaxInformationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetTaxInformationQuery, PaginatedResponse<TaxInformationResponse>>
    {
        public Task<PaginatedResponse<TaxInformationResponse>> Handle(GetTaxInformationQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
