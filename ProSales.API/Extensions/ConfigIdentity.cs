using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using ProSales.Application;
using ProSales.Application.Contracts;
using ProSales.Domain.Identity;
using ProSales.Repository;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigIdentity
    {

        public static IServiceCollection AddConfigIdentity(
             this IServiceCollection services)
        {
            services.AddIdentity<User, Role>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;

            })
            .AddRoles<Role>()
            .AddEntityFrameworkStores<ProSalesContext>()
            .AddRoleValidator<RoleValidator<Role>>()
            .AddRoleManager<RoleManager<Role>>()
            .AddSignInManager<SignInManager<User>>()
            .AddDefaultTokenProviders();

            return services;
        }
    }
}