using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace Application
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddAutoMapper(assembly);
            services.AddValidatorsFromAssembly(assembly);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            return services;
        }
    }
}
