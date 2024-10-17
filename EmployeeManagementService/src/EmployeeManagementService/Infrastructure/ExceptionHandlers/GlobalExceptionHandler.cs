using EmployeeManagementService.Common.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace EmployeeManagementService.Infrastructure.ExceptionHandlers
{
    public class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger, IWebHostEnvironment env) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            logger.LogError("{0}", exception);
            var response = new Dictionary<string, string>();

            switch (exception)
            {
                case DuplicateEntityException duplicateEntityException:
                    response.Add("errors", duplicateEntityException.Message);
                    httpContext.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                    break;
                
                case EntityNotFoundException entityNotFoundException:
                    response.Add("errors", entityNotFoundException.Message);
                    httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                default:
                    response.Add("errors", "Internal Server Error");
                    if (env.IsDevelopment())
                    {
                        response.Add("StackTrace", exception.StackTrace);
                    }

                    httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken: cancellationToken);

            return true;
        }
    }
}
