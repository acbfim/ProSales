using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProSales.Repository;
using ProSales.Repository.Contracts;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigServiceCollectionExtensions
    {

        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
             services.AddScoped<IGlobalRepository, GlobalRepository>();
             //services.AddScoped<IUserService, UserService>();
             //services.AddScoped<IRoleService, RoleService>();

            return services;
        }
    }
}