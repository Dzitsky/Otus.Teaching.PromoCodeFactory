using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.DataAccess.Repositories;
using System;

namespace Otus.Teaching.PromoCodeFactory.DataAccess
{    public static class DataAccessModule
    {
        public sealed class ModuleConfiguration
        {
            public IServiceCollection Services { get; init; }
        }

        public static IServiceCollection AddDataAccessModule(
            this IServiceCollection services,
            Action<ModuleConfiguration> action
        )
        {
            var moduleConfiguration = new ModuleConfiguration
            {
                Services = services
            };
            action(moduleConfiguration);
            return services;
        }

        public static void InPostgress(this ModuleConfiguration moduleConfiguration, string connectionString)
        {
            moduleConfiguration.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(
                    connectionString
                    //Environment.GetEnvironmentVariable("")
                    , builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));

                //options.UseLazyLoadingProxies();

                    //typeof(DatabaseContextModelSnapshot).Assembly.FullName

            });


            
                moduleConfiguration.Services.AddScoped(typeof(IRepository<Employee>), typeof(EmployeeRepository));
            moduleConfiguration.Services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
        }
    }
}
