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

            CreateMap<Cart, CreateCartDto>().ReverseMap();
            CreateMap<Cart, CartDto>().ReverseMap();
            CreateMap<Cart, CartDtoAddProduct>().ReverseMap();

            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Client, ClientDtoAddCart>().ReverseMap();
            CreateMap<Client, CreateClientDto>().ReverseMap();

            CreateMap<Contact, CreateContactDto>().ReverseMap();

            CreateMap<ContactType, ContactTypeDto>().ReverseMap();
            CreateMap<ContactType, CreateContactTypeDto>().ReverseMap();

            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, BrandDto>().ReverseMap();
            
            CreateMap<ContactType, CreateContactTypeDto>().ReverseMap();
            CreateMap<ContactType, ContactTypeDto>().ReverseMap();

            CreateMap<DiscountType, CreateDiscountTypeDto>().ReverseMap();
            CreateMap<DiscountType, DiscountTypeDto>().ReverseMap();

            CreateMap<DocumentType, CreateDocumentTypeDto>().ReverseMap();
            CreateMap<DocumentType, DocumentTypeDto>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductDtoAddCart>().ReverseMap();

            CreateMap<ProductCart, ProductCartDto>().ReverseMap();

            CreateMap<ProductType, CreateProductTypeDto>().ReverseMap();
            CreateMap<ProductType, ProductTypeDto>().ReverseMap();
        }
        
    }
}