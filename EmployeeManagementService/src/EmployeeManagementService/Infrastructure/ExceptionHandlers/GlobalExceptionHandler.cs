using EmployeeManagementService.Common.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace EmployeeManagementService.Infrastructure.ExceptionHandlers
{
    public class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger, IWebHostEnvironment env) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            switch (exception)
            {
                case DuplicateEntityException duplicateEntityException:
                    await httpContext.Response.WriteAsJsonAsync(new { Errors = duplicateEntityException.Message }, cancellationToken: cancellationToken);
                    httpContext.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                    break;
                
                case EntityNotFoundException entityNotFoundException:
                    await httpContext.Response.WriteAsJsonAsync(new { Errors = entityNotFoundException.Message }, cancellationToken: cancellationToken);
                    httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                default:
                    if (env.IsDevelopment())
                    {
                        await httpContext.Response.WriteAsJsonAsync(new { Errors = "Internal Server Error", exception.StackTrace }, cancellationToken: cancellationToken);
                    }
                    else
                    {
                        await httpContext.Response.WriteAsJsonAsync(new { Errors = "Internal Server Error" }, cancellationToken: cancellationToken);
                    }

                    httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            logger.LogError("{0}", exception);

            return true;
        }
    }
}
