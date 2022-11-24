using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProSales.Application;
using ProSales.Application.Contracts;
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

            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            
            services.AddScoped<ICalculationTypeRepository, CalculationTypeRepository>();

            services.AddScoped<IContactTypeService, ContactTypeService>();
            services.AddScoped<IContactTypeRepository, ContactTypeRepository>();

            services.AddScoped<IDiscountTypeService, DiscountTypeService>();
            services.AddScoped<IDiscountTypeRepository, DiscountTypeRepository>();

            services.AddScoped<IDocumentTypeService, DocumentTypeService>();
            services.AddScoped<IDocumentTypeRepository, DocumentTypeRepository>();

            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();



            return services;
        }
    }
}