using EmployeeManagementService.Business.Features.Employees.Commands;
using EmployeeManagementService.Infrastructure.Persistence;
using MediatR;

namespace EmployeeManagementService.Business.Features.Employees.Handlers;

public class DeleteEmployeeCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<DeleteEmployeeCommand>
{
    public async Task Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        
        var existingEmployee = await unitOfWork.EmployeeRepository.Get(request.EmployeeId);
        if (existingEmployee == null)
        {
            //todo through validation exception
        }

        await unitOfWork.EmployeeRepository.Remove(existingEmployee);
    }
}