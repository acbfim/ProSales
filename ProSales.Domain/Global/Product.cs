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
        public ProductType ProductType { get; set; }

        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "varchar(300)")]
        [StringLength(300)]
        public string? Description { get; set; }
        public double Price { get; set; } = 0.0;

        [Column(TypeName = "varchar(300)")]
        [StringLength(300)]
        public string? ImageUrl { get; set; }
        public DiscountType? DiscountType { get; set; }
        public double Discount { get; set; } = 0.0;
        public Brand? Brand { get; set; }
        public ICollection<Inventory>? Inventory { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public User? UserCreated { get; set; }
        public ICollection<Specification>? Specifications { get; set; }
        public bool IsActive { get; set; } = true;
        
    }
}