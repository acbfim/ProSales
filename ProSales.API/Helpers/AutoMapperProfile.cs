using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;

namespace ProSales.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Address, CreateAddressDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();

            CreateMap<CalculationType, CalculationTypeDto>().ReverseMap();
            CreateMap<CalculationType, CalculationTypeExternal>().ReverseMap();

            CreateMap<Cart, CreateCartDto>().ReverseMap();
            CreateMap<Cart, CartDto>().ReverseMap();
            CreateMap<Cart, CartDtoAddProduct>().ReverseMap();

            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Client, CreateClientDto>().ReverseMap();
            CreateMap<Client, ClientExternal>().ReverseMap();

            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            

            CreateMap<ContactType, ContactTypeDto>().ReverseMap();
            CreateMap<ContactType, CreateContactTypeDto>().ReverseMap();
            CreateMap<ContactType, ContactTypeExternal>().ReverseMap();

            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Brand, BrandExternal>().ReverseMap();
            
            CreateMap<ContactType, CreateContactTypeDto>().ReverseMap();
            CreateMap<ContactType, ContactTypeDto>().ReverseMap();

            CreateMap<DiscountType, CreateDiscountTypeDto>().ReverseMap();
            CreateMap<DiscountType, DiscountTypeDto>().ReverseMap();
            CreateMap<DiscountType, DiscountTypeExternal>().ReverseMap();

            CreateMap<Document, DocumentDto>().ReverseMap();
            CreateMap<Document, CreateDocumentDto>().ReverseMap();

            CreateMap<DocumentType, CreateDocumentTypeDto>().ReverseMap();
            CreateMap<DocumentType, DocumentTypeExternal>().ReverseMap();
            CreateMap<DocumentType, DocumentTypeDto>().ReverseMap();

            CreateMap<Inventory, CreateInventoryDto>().ReverseMap();
            CreateMap<Inventory, InventoryDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductExternal>().ReverseMap();

            CreateMap<ProductCart, ProductCartDto>().ReverseMap();

            CreateMap<ProductSale, ProductSaleDto>().ReverseMap();

            CreateMap<ProductType, CreateProductTypeDto>().ReverseMap();
            CreateMap<ProductType, ProductTypeDto>().ReverseMap();
            CreateMap<ProductType, ProductTypeExternal>().ReverseMap();

            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();

            CreateMap<Specification, SpecificationDto>().ReverseMap();

            CreateMap<CoinType, CoinTypeExternal>().ReverseMap();
            CreateMap<CoinType, CoinTypeDto>().ReverseMap();

            CreateMap<Sale, CreateSaleDto>().ReverseMap();
            CreateMap<Sale, SaleDtoAddProduct>().ReverseMap();
            CreateMap<Sale, SaleDto>().ReverseMap();
            CreateMap<Sale, SaleExternal>().ReverseMap();

            CreateMap<ProductSale, CreateProductSaleDto>().ReverseMap();
            CreateMap<ProductSale, UpdateDiscountProductSaleDto>().ReverseMap();
            CreateMap<ProductSale, ProductSaleDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
        }
        
    }
}