using AutoMapper;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Business.Features.Departments.Responses;
using EmployeeManagementService.Domain.Employee;

namespace EmployeeManagementService.Business.Features.Departments.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<CreateDepartmentCommand, Department>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name));

            CreateMap<Department,CreateDepartmentCommand>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name));

            CreateMap<Department, DepartmentResponse>();
        }
    }
}
