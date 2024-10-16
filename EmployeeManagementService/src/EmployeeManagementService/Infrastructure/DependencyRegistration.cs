using Asp.Versioning;
using Microsoft.AspNetCore.HttpLogging;

namespace EmployeeManagementService.Infrastructure
{
    public static class DependencyRegistration
    {
        public static IServiceCollection RegisterSwagger(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }

        public static IServiceCollection RegisterCors(this IServiceCollection services)
        {
            services.AddCors();

            return services;
        }

        public static IServiceCollection RegisterApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(o =>
            {
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
                o.ReportApiVersions = true;
                o.ApiVersionReader = ApiVersionReader.Combine(
                    new QueryStringApiVersionReader("api-version"),
                    new HeaderApiVersionReader("X-Version"),
                    new MediaTypeApiVersionReader("ver"));
            });

            return services;
        }

        public static IServiceCollection RegisterLogging(this IServiceCollection services)
        {
            services.AddHttpLogging(logging =>
            {
                logging.LoggingFields = HttpLoggingFields.All;
                logging.RequestBodyLogLimit = 4096;
                logging.ResponseBodyLogLimit = 4096;
                logging.MediaTypeOptions.AddText("application/json");
                logging.RequestHeaders.Add("User-Agent");
            });

            return services;
        }
    }
}
