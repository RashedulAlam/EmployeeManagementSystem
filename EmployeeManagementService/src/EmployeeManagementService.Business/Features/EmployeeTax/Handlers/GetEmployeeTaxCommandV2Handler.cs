using AutoMapper;
using EmployeeManagementService.Business.Features.EmployeeTax.Queries;
using EmployeeManagementService.Business.Features.EmployeeTax.Responses;
using EmployeeManagementService.Common.Exceptions;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.EmployeeTax.Handlers
{
    internal class GetEmployeeTaxCommandV2Handler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetEmployeeTaxQueryV2, IReadOnlyCollection<EmployeeTaxInformationResponse>>
    {
        public async Task<IReadOnlyCollection<EmployeeTaxInformationResponse>> Handle(GetEmployeeTaxQueryV2 request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.EmployeeRepository.Get(request.EmployeeId);

            if (employee == null)
            {
                throw new EntityNotFoundException(nameof(Employee), request.EmployeeId.ToString());
            }

            return new List<EmployeeTaxInformationResponse>();
        }
    }
}
