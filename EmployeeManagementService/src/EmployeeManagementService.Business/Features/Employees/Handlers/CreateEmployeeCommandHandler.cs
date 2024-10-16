using AutoMapper;
using EmployeeManagementService.Business.Features.Employees.Commands;
using EmployeeManagementService.Business.Features.Employees.Responses;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.Employees.Handlers
{
    public class CreateEmployeeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = mapper.Map<Employee>(request);

            //todo add validation employee does not exist 
            //todo add validation department exist
    
            var newEmployee = await unitOfWork.EmployeeRepository.Add(employee);

            return mapper.Map<EmployeeResponse>(newEmployee);
        }
    }
}
