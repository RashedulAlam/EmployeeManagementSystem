using AutoMapper;
using EmployeeManagementService.Business.Features.Employees.Queries;
using EmployeeManagementService.Business.Features.Employees.Responses;
using EmployeeManagementService.Common.Exceptions;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.Employees.Handlers
{
    public sealed class GetEmployeeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetEmployeeQuery, EmployeeResponse>
    {
        public async Task<EmployeeResponse> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employee= await unitOfWork.EmployeeRepository.Get(request.Id);

            if (employee == null)
            {
                throw new EntityNotFoundException(nameof(Employee), request.Id.ToString());
            }

            return mapper.Map<EmployeeResponse>(employee);
        }
    }
}
