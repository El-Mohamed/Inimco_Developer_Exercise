using DeveloperExercise.Infrastructure.IOC;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeveloperExercise.Application.IOC
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructureLayerServices(configuration);

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IServiceCollectionExtensions).Assembly));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));

            return services;
        }
    }
}
