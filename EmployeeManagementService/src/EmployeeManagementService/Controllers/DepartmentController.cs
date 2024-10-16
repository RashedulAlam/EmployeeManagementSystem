using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using AutoMapper;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Business.Features.Departments.Responses;
using EmployeeManagementService.Models.Requests.Department;
using MediatR;

namespace EmployeeManagementService.Controllers
{
    [Route("api/v1/departments")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiExplorerSettings(GroupName = "v1")]
    public class DepartmentController(IMediator mediator, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public async Task<DepartmentResponse> Get([FromRoute] GetDepartmentRequest request)
        {
            return await mediator.Send(mapper.Map<CreateDepartmentCommand>(request));
        }

        [HttpPost]
        public async Task<DepartmentResponse> Create([FromBody] CreateDepartmentRequest request)
        {
            return await mediator.Send(mapper.Map<CreateDepartmentCommand>(request));
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<DepartmentResponse> Update([FromBody] UpdateDepartmentRequest request)
        {
            return await mediator.Send(mapper.Map<CreateDepartmentCommand>(request));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<DepartmentResponse> Delete([FromRoute] DeleteDepartmentRequest request)
        {
            return await mediator.Send(mapper.Map<CreateDepartmentCommand>(request));
        }
    }
}
