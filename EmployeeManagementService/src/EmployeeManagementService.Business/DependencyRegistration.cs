using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementService.Business
{
    public static class DependencyRegistration
    {
        public static IServiceCollection RegisterBusinessDependencies(this IServiceCollection services)
        {

            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssemblies(typeof(DependencyRegistration).Assembly);
            });

            return services;
        }
    }
}
