using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class Product
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();
        

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? Description { get; set; }
        public double Price { get; set; } = 0.0;

        [Column(TypeName = "varchar(300)")]
        public string? ImageUrl { get; set; }
        public double Discount { get; set; } = 0.0;


        public long ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public long? DiscountTypeId { get; set; }
        public DiscountType? DiscountType { get; set; }
        public long BrandId { get; set; }
        public Brand? Brand { get; set; }


        public ICollection<Inventory>? Inventory { get; set; }
        public ICollection<Specification>? Specifications { get; set; }
        public ICollection<ProductCart>? ProductsCart { get; set; }
        public ICollection<ProductOrder>? ProductsOrder { get; set; }
        

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int? UserCreatedId { get; set; }
        public int? UserUpdatedId { get; set; }
        public User? UserCreated { get; set; }
        public User? UserUpdated { get; set; }

        public bool IsActive { get; set; } = true;
        
    }
}