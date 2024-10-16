using AutoMapper;
using EmployeeManagementService.Business.Features.Employees.Commands;
using EmployeeManagementService.Business.Features.Employees.Responses;
using EmployeeManagementService.Models.Requests.Employee;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace EmployeeManagementService.Controllers
{
    [Route("api/v1/employees")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    public class EmployeeController(IMediator mediator, IMapper mapper) : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType<EmployeeResponse>(StatusCodes.Status200OK)]
        public async Task<EmployeeResponse> Create([FromBody] CreateEmployeeRequest request)
        {
            return await mediator.Send(mapper.Map<CreateEmployeeCommand>(request));
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType<EmployeeResponse>(StatusCodes.Status200OK)]
        public async Task<EmployeeResponse> Update(UpdateEmployeeRequest request)
        {
            return await mediator.Send(mapper.Map<CreateEmployeeCommand>(request));
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType<EmployeeResponse>(StatusCodes.Status200OK)]
        public async Task<EmployeeResponse> Get(GetEmployeeRequest request)
        {
            return await mediator.Send(mapper.Map<CreateEmployeeCommand>(request));
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType<EmployeeResponse>(StatusCodes.Status200OK)]
        public async Task<EmployeeResponse> Delete(DeleteEmployeeRequest request)
        {
            return await mediator.Send(mapper.Map<CreateEmployeeCommand>(request));
        }
    }
}
