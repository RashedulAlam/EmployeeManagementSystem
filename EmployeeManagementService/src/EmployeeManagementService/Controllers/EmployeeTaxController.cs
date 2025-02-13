﻿using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using AutoMapper;
using EmployeeManagementService.Business.Features.Common.Responses;
using MediatR;
using EmployeeManagementService.Business.Features.EmployeeTax.Queries;
using EmployeeManagementService.Business.Features.EmployeeTax.Responses;
using EmployeeManagementService.Models.Requests.TaxInformation;

namespace EmployeeManagementService.Controllers
{
    [Route("api/v1/employees")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiExplorerSettings(GroupName = "v1")]
    public class EmployeeTaxController(IMediator mediator, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        [Route("tax-information")]
        public async Task<PaginatedResponse<TaxInformationResponse>> GetTaxInformations([FromBody] TaxInformationRequest request)
        {
            return await mediator.Send(mapper.Map<GetTaxInformationQuery>(request));
        }

        [HttpGet]
        [Route("{id}/tax-information")]
        public async Task<IReadOnlyCollection<EmployeeTaxInformationResponse>> GetTaxInformation([FromRoute] EmployeeTaxInformationRequest request)
        {
            return await mediator.Send(mapper.Map<GetEmployeeTaxQuery>(request));
        }
    }
}
