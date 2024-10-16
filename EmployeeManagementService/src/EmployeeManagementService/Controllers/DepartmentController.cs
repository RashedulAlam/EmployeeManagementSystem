using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace EmployeeManagementService.Controllers
{
    [Route("api/v{version:apiVersion}/departments")]
    [ApiVersion("1.0")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    public class DepartmentController : ControllerBase
    {

    }
}
