using DeveloperExercise.Application.Command.SavePerson;
using DeveloperExercise.Domain.Model;
using DeveloperExercise.Infrastructure.IOC;
using FluentValidation;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeveloperExercise.Application.IOC
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructureLayerServices(configuration);

            services.AddScoped<IValidator<SavePersonCommand>, SaveUserCommandValidator>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IServiceCollectionExtensions).Assembly));

            return services;
        }
    }
}
