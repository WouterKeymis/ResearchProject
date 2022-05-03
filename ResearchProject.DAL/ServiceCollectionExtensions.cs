using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResearchProject.DAL.Persistance;
using ResearchProject.DAL.Persistance.Enums;
using ResearchProject.DAL.Persistance.Interfaces;
using ResearchProject.Models;

namespace ResearchProject.DAL
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {
            services
                .AddDatabaseConnections()
                .AddScoped<IPersonRepository, PersonRepository>()
                .AddScoped<IVetenaryRepository, VetenaryRepository>();

            return services;
        }

        private static IServiceCollection AddDatabaseConnections(this IServiceCollection services)
        {
            IConfiguration configuration = services.BuildServiceProvider().GetService<IConfiguration>();

            var connectionStrings = GetDatabaseConnectionStringsDictionary(configuration);

            services
                .AddSingleton(connectionStrings)
                .AddTransient<IDbConnectionFactory, DapperDbConnectionFactory>();

            return services;
        }


        private static IDictionary<DatabaseConnectionName, string> GetDatabaseConnectionStringsDictionary(IConfiguration configuration)
            => new Dictionary<DatabaseConnectionName, string>()
            {
                { DatabaseConnectionName.ResearchProject, configuration.GetConnectionString("ResearchDB") }
            };
    }
}