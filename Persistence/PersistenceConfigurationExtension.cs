using Microsoft.Extensions.DependencyInjection;
using Persistence.Mapper;

namespace Persistence
{
    public static class PersistenceConfigurationExtension
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(OperationMappingProfile).Assembly);
            return services;
        }
    }
}
