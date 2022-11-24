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
        public User Seller { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Product Product { get; set; }
        public double AmountProductSale { get; set; }
    }
}