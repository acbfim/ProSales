using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProSales.Application;
using ProSales.Application.Contracts;
using ProSales.Domain.Identity;
using ProSales.Repository;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigContexts
    {

        public static IServiceCollection AddConfigContexts(
             this IServiceCollection services, IConfigurationSection section)
        {

            var connectionStringDefault = section["MariaDBContext"];

            services.AddDbContext<ProSalesContext>(
                x => x.UseMySql(connectionStringDefault, ServerVersion.AutoDetect(connectionStringDefault))
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
            );
            return services;
        }
    }
}