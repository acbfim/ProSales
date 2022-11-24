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

            CreateMap<CalculationType, CalculationTypeDto>().ReverseMap();

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

            CreateMap<ProductType, CreateProductTypeDto>().ReverseMap();
            CreateMap<ProductType, ProductTypeDto>().ReverseMap();
        }
        
    }
}