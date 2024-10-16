using EmployeeManagementService.Infrastructure.External.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementService.Infrastructure.External
{
    public static class DependencyRegistration
    {
        public static IServiceCollection RegisterExternalDependencies(this IServiceCollection services)
        {
            services.AddTransient<ITaxHttpClient, TaxHttpClient>();

            return services;
        }
    }
}
