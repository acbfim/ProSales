using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Dtos
{
    public partial class ProductDto
    {
        public Guid ExternalId { get; set; }
        
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; } = 0.0;
        public string? ImageUrl { get; set; }
        public double Discount { get; set; } = 0.0;
        public ProductTypeDto ProductType { get; set; }
        public DiscountTypeDto? DiscountType { get; set; }
        public BrandDto Brand { get; set; }
        public ICollection<SpecificationDto> Specifications { get; set; }

        public bool IsActive { get; set; }
    }
}