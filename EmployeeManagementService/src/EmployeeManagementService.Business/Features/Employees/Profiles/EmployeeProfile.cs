using AutoMapper;
using EmployeeManagementService.Business.Features.Employees.Commands;
using EmployeeManagementService.Business.Features.Employees.Responses;
using EmployeeManagementService.Domain.Employee;

namespace EmployeeManagementService.Business.Features.Employees.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateEmployeeCommand, Employee>()
                .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(x => x.FirstName, opt => opt.MapFrom(x => x.FirstName))
                .ForMember(x => x.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(x => x.HireDate, opt => opt.MapFrom(x => x.HireDate))
                .ForMember(x => x.DepartmentId, opt => opt.MapFrom(x => x.DepartmentId));

            CreateMap<Employee, EmployeeResponse>()
                .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.FirstName, opt => opt.MapFrom(x => x.FirstName))
                .ForMember(x => x.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(x => x.HireDate, opt => opt.MapFrom(x => x.HireDate))
                .ForMember(x => x.DepartmentId, opt => opt.MapFrom(x => x.DepartmentId))
                .ForMember(x => x.DepartmentName, opt => opt.MapFrom(x => x.Department != null ? x.Department.Name : null));
        }
    }
}
