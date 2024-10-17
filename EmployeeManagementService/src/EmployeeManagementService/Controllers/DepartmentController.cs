using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using AutoMapper;
using EmployeeManagementService.Business.Features.Departments.Commands;
using EmployeeManagementService.Business.Features.Departments.Queries;
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
    public class DepartmentController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public async Task<DepartmentResponse> Get(string id)
        {
            return await mediator.Send(new GetDepartmentQuery {Id = id} );
        }

        [HttpPost]
        public async Task<DepartmentResponse> Create([FromBody] CreateDepartmentRequest request)
        {
            return await mediator.Send(new CreateDepartmentCommand
            {
                Name = request.Name

            });
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<DepartmentResponse> Update([FromBody] UpdateDepartmentRequest request, string id)
        {
            return await mediator.Send(new UpdateDepartmentCommand
            {
                Id = id, Name = request.Name,

            });
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task Delete(string id)
        {
            await mediator.Send(new DeleteDepartmentCommand{Id = id});
        }
    }
}
