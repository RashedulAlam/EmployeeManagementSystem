using System.Net.Mime;
using AutoMapper;
using EmployeeManagementService.Business.Features.Common.Responses;
using EmployeeManagementService.Business.Features.EmployeeTax.Queries;
using EmployeeManagementService.Business.Features.EmployeeTax.Responses;
using EmployeeManagementService.Infrastructure.External.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementService.Controllers.V2
{
    [Route("api/v2/employees")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiExplorerSettings(GroupName = "v2")]
    public class EmployeeTaxController(IMediator mediator, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        [Route("tax-information")]
        public async Task<PaginatedResponse<TaxInformationResponse>> GetTaxInformations([FromRoute] TaxInformationRequest request)
        {
            return await mediator.Send(mapper.Map<GetTaxInformationQuery>(request));
        }

        [HttpGet]
        [Route("{id}/tax-information")]
        public async Task<IReadOnlyCollection<EmployeeTaxInformationResponse>> GetTaxInformation([FromRoute] TaxInformationRequest request)
        {
            return await mediator.Send(mapper.Map<GetEmployeeTaxQuery>(request));
        }
    }
}
