using DeveloperExercise.Domain.Repositories;
using DeveloperExercise.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeveloperExercise.Infrastructure.IOC
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();

            return services;
        }
    }
}
