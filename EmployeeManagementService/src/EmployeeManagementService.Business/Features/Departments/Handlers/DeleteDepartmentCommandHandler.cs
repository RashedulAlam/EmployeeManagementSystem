using AutoMapper;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Common.Exceptions;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.Departments.Handlers;

public class DeleteDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<DeleteDepartmentCommand>
{

    public async Task Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
    {
        var department = await unitOfWork.DepartmentRepository.Get(request.Id);

        if (department == null)
        {
            throw new EntityNotFoundException(nameof(Department), request.Id);
        }

        await unitOfWork.DepartmentRepository.Remove(request.Id);
    }
}