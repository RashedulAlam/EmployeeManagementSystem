using AutoMapper;
using EmployeeManagementService.Business.Features.Departments.Queries;
using EmployeeManagementService.Business.Features.Departments.Responses;
using EmployeeManagementService.Common.Exceptions;
using EmployeeManagementService.Domain.Employee;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.Departments.Handlers
{
    public sealed class GetDepartmentQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetDepartmentQuery, DepartmentResponse>
    {
        public async Task<DepartmentResponse> Handle(GetDepartmentQuery request, CancellationToken cancellationToken)
        {
            var department = await unitOfWork.DepartmentRepository.Get(request.Id);

            if (department == null)
            {
                throw new EntityNotFoundException(nameof(Department), request.Id);
            }

            return mapper.Map<DepartmentResponse>(department);
        }
    }
}
