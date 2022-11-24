using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Global
{
    public class Order
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();
        public DateTime EffectiveDate { get; set; }
        public Client? Client { get; set; }
        public ICollection<Product>? Products { get; set; }
        public TypeCoin TypeCoin { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}