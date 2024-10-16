using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace EmployeeManagementService.Controllers
{
    [Route("api/v1/employees")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    public class EmployeeTaxController : ControllerBase
    {
        [HttpGet]
        [Route("{id}/tax")]
        public IActionResult GetTaxInformation([FromRoute] string id)
        {
            return null;
        }
    }
}
