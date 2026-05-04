using Application.Common.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationConfigurations
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            var assembly = typeof(ApplicationConfigurations).Assembly;

            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehaviour<,>));

            //var encriptionSectionName = configuration.GetSection(EncriptionOptions.SectionName);
            //services.Configure<EncriptionOptions>(encriptionSectionName);

            //var tokenSectionName = configuration.GetSection(TokenManageOptions.SectionName);
            //services.Configure<TokenManageOptions>(tokenSectionName);

            return services;
        }
    }
}
