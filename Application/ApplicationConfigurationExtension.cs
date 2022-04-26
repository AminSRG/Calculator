using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationConfigurationExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IServices.ICalculatorRepository, Services.CalculatorRepository>();

            return services;
        }
    }
}
