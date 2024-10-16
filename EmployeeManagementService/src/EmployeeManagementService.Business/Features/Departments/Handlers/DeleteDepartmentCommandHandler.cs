using AutoMapper;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.Departments.Handlers;

public class DeleteDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<DeleteDepartmentCommand>
{

    public async Task Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
    {
        var department = mapper.Map<Department>(request);

        var newDepartment = await unitOfWork.DepartmentRepository.Add(department);
    }
}