using AutoMapper;
using MediatR;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Business.Features.Departments.Responses;
using EmployeeManagementService.Common.Exceptions;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementService.Business.Features.Departments.Handlers
{
    public class CreateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        : IRequestHandler<CreateDepartmentCommand, DepartmentResponse>
    {

        public async Task<DepartmentResponse> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = mapper.Map<Department>(request);

            var existingDepartment = await unitOfWork.DepartmentRepository.GetAll(x => x.Name == request.Name)
                .FirstOrDefaultAsync(cancellationToken: cancellationToken);

            if (existingDepartment != null)
            {
                throw new DuplicateEntityException(nameof(Department), nameof(Department.Name));
            }

            var newDepartment = await unitOfWork.DepartmentRepository.Add(department);

            return mapper.Map<DepartmentResponse>(newDepartment);
        }
    }
}
