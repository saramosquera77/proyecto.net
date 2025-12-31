using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repository;
using System.Reflection;

namespace Persistence
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuracion)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                configuracion.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            // Register DateTime service
            services.AddSingleton<Application.Interfaces.IDateTimeService, Infrastructure.DateTimeService>();

            // Repositories
            services.AddTransient(typeof(Application.Interfaces.IRepositoryAsync<>), typeof(MyRepositoryAsync<>));

            return services;
        }
    }
}
