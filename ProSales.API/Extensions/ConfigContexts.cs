using Microsoft.EntityFrameworkCore;
using ProSales.Repository.Contexts;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigContexts
    {

        public static IServiceCollection AddConfigContexts(this IServiceCollection services,
                                                           IConfigurationSection section)
        {
            var stringteste = "server=191.252.101.136;uid=prosales;" +"pwd=Copa#2026;database=ProSales";

            services.AddDbContext<ProSalesContext>(
                x => x.UseMySql(section["MariaDBContext"], ServerVersion.AutoDetect(section["MariaDBContext"]))
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
            );

            // services.AddDbContext<ProSalesContext>(
            //     x => x.UseMySQL(stringteste)
            // );


            return services;
        }
    }
}