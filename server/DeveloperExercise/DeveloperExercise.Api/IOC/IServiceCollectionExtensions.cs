using DeveloperExercise.Domain.Configurations;

namespace DeveloperExercise.Api.IOC
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddApiLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<FileBasedDatabaseOptions>(configuration.GetSection("FileBasedDatabase"));
            return services;
        }
    }
}
