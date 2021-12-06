using MamtakNetApp.Infrastructure;
using MamtakNetApp.Interfaces;
using MamtakNetApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weather.Interfaces;

namespace Weather.Infrastructure
{
    public static class ServiceCollectionExtensions
    {

        public static void RegisterContext(this IServiceCollection services, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("WeatherConnection");

            services.AddDbContext<CandyContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(connectionString);

            });
        }
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICandyService, CandyService>();
        }

    }
}
