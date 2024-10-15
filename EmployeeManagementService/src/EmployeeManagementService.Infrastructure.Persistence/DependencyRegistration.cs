using EmployeeManagementService.Infrastructure.persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementService.Infrastructure.Persistence
{
    public static class DependencyRegistration
    {
        public static IServiceCollection RegisterPersistenceDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<EmployeeDbContext>(builder =>
            {
                builder.UseNpgsql(configuration.GetConnectionString("default"), optionsBuilder =>
                    {
                        optionsBuilder.MigrationsAssembly(typeof(EmployeeDbContext).Assembly.FullName);
                        optionsBuilder.CommandTimeout(300);
                    })
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
