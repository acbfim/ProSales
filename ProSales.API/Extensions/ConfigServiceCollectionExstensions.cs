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

            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressRepository, AddressRepository>();

            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartService, CartService>();

            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactService, ContactService>();

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientService, ClientService>();
            
            services.AddScoped<ICalculationTypeRepository, CalculationTypeRepository>();

            services.AddScoped<IContactTypeService, ContactTypeService>();
            services.AddScoped<IContactTypeRepository, ContactTypeRepository>();

            services.AddScoped<IDiscountTypeService, DiscountTypeService>();
            services.AddScoped<IDiscountTypeRepository, DiscountTypeRepository>();

            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();

            services.AddScoped<IDocumentTypeService, DocumentTypeService>();
            services.AddScoped<IDocumentTypeRepository, DocumentTypeRepository>();

            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IInventoryService, InventoryService>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IProductSaleRepository, ProductSaleRepository>();

            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();

            services.AddScoped<ISaleService, SaleService>();
            services.AddScoped<ISaleRepository, SaleRepository>();

            services.AddScoped<IUserManagerRepository, UserManagerRepository>();



            return services;
        }
    }
}