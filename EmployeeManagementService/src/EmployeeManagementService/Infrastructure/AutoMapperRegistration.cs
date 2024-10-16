using System.Reflection;

namespace EmployeeManagementService.Infrastructure
{
    public static class AutoMapperRegistration
    {
        public static IServiceCollection RegisterAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
