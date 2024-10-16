using AutoMapper;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Business.Features.Departments.Responses;
using EmployeeManagementService.Common.Exceptions;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementService.Business.Features.Departments.Handlers;

public class UpdateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<UpdateDepartmentCommand, DepartmentResponse>
{

    public async Task<DepartmentResponse> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var department = await unitOfWork.DepartmentRepository.Get(request.Id);

        if (department == null)
        {
            throw new EntityNotFoundException(nameof(Department), request.Id);
        }

        var existingDepartment = await unitOfWork.DepartmentRepository.GetAll(x => x.Name == request.Name && x.Id != request.Id)
            .FirstOrDefaultAsync(cancellationToken: cancellationToken);

        if (existingDepartment != null)
        {
            throw new DuplicateEntityException(nameof(Department), nameof(Department.Name));
        }

        department.Name = request.Name;

        var updatedDepartment = await unitOfWork.DepartmentRepository.Update(department);

        await unitOfWork.SaveChanges();

        return mapper.Map<DepartmentResponse>(updatedDepartment);
    }
}