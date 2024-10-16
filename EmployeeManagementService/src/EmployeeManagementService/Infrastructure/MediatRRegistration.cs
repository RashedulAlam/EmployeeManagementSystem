namespace EmployeeManagementService.Infrastructure
{
    public static class MediatRRegistration
    {
        public static IServiceCollection RegisterMediatRDependencies(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                
            });

            return services;
        }
    }
}
