using AutoMapper;
using MediatR;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Business.Features.Departments.Responses;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;

namespace EmployeeManagementService.Business.Features.Departments.Handlers
{
    public class CreateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        : IRequestHandler<CreateDepartmentCommand, DepartmentResponse>
    {

        public async Task<DepartmentResponse> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = mapper.Map<Department>(request);

            var newDepartment = await unitOfWork.DepartmentRepository.Add(department);

            return mapper.Map<DepartmentResponse>(newDepartment);
        }
    }
}
