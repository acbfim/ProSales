using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class Inventory
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();
        public Product Product { get; set; }
        public string? BarCode { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}