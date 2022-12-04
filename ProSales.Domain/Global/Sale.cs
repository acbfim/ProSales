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
        
        public double Amount { get; set; } = 0.0;


        public long? ClientId { get; set; }
        public Client? Client { get; set; }
        public long? CoinTypeId { get; set; }
        public CoinType CoinType { get; set; }
        public int? SellerId { get; set; }
        public User? Seller { get; set; }

        public ICollection<ProductSale>? ProductsSale { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime FinishedAt { get; set; }
    }
}