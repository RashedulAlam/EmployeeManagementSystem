using AutoMapper;
using EmployeeManagementService.Business.Features.EmployeeTax.Queries;
using EmployeeManagementService.Business.Features.EmployeeTax.Responses;
using EmployeeManagementService.Common.Exceptions;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.External.Clients;
using EmployeeManagementService.Infrastructure.External.Requests;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.EmployeeTax.Handlers
{
    public sealed class GetEmployeeTaxCommandHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ITaxHttpClient taxHttpClient) : IRequestHandler<GetEmployeeTaxQuery, IReadOnlyCollection<EmployeeTaxInformationResponse>>
    {
        public async Task<IReadOnlyCollection<EmployeeTaxInformationResponse>> Handle(GetEmployeeTaxQuery request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.EmployeeRepository.Get(request.EmployeeId);

            if (employee == null)
            {
                throw new EntityNotFoundException(nameof(Employee), request.EmployeeId.ToString());
            }

            var employeeTaxInformations =
                await taxHttpClient.GetTaxInformation(mapper.Map<TaxInformationRequest>(request));


            return mapper.Map<IReadOnlyCollection<EmployeeTaxInformationResponse>>(employeeTaxInformations);
        }
    }
}
