using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class ProductSale
    {
        public Guid ExternalId { get; set; } = Guid.NewGuid();

        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long SaleId { get; set; }
        public Sale Sale { get; set; }
        public double Discount { get; set; }
        public long? DiscountTypeId { get; set; }
        public DiscountType? DiscountType { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int? UserCreatedId { get; set; }
        public User? UserCreated { get; set; }
        public int? UserUpdatedId { get; set; }
        public User? UserUpdated { get; set; }
    }
}