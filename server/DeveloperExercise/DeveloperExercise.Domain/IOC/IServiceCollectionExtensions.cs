using DeveloperExercise.Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeveloperExercise.Domain.IOC
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPersonService, PersonService>();
            return services;
        }
    }
}
