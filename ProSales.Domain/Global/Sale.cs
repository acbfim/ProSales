using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class Sale
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();
        public Client? Client { get; set; }
        public TypeCoin TypeCoin { get; set; }
        public double Amount { get; set; } = 0.0;
        public User? Seller { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}