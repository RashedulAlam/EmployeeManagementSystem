using EmployeeManagementService.Common.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace EmployeeManagementService.Infrastructure.ExceptionHandlers
{
    public class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            switch (exception)
            {
                case DuplicateEntityException duplicateEntityException:
                    await httpContext.Response.WriteAsJsonAsync(new { Errors = exception.Message }, cancellationToken: cancellationToken);
                    httpContext.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                    break;
                
                case EntityNotFoundException entityNotFoundException:
                    await httpContext.Response.WriteAsJsonAsync(new { Errors = exception.Message }, cancellationToken: cancellationToken);
                    httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;
            }

            logger.LogError("{0}", exception);

            return true;
        }
    }
}
