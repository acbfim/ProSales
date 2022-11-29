using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class HistoryProductSale
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();

        public double AmountProductSale { get; set; }

        public int SellerId { get; set; }
        public User Seller { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
    }
}