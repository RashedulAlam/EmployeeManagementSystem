using AutoMapper;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Business.Features.Departments.Responses;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.Departments.Handlers;

public class UpdateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<UpdateDepartmentCommand, DepartmentResponse>
{

    public async Task<DepartmentResponse> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var department = mapper.Map<Department>(request);

        var newDepartment = await unitOfWork.DepartmentRepository.Add(department);

        return mapper.Map<DepartmentResponse>(newDepartment);
    }
}