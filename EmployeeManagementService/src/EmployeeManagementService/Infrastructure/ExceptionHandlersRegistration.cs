using EmployeeManagementService.Infrastructure.ExceptionHandlers;

namespace EmployeeManagementService.Infrastructure
{
    public static class ExceptionHandlersRegistration
    {
        public static IServiceCollection RegisterExceptionHandlers(this IServiceCollection services)
        {
            services.AddExceptionHandler<GlobalExceptionHandler>();

            return services;
        }
    }
}
