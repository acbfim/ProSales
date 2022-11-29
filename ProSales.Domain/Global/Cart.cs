using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Global
{
    public class Cart
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();

        public ICollection<ProductCart> ProductsCart { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public long ClientId { get; set; }
        public Client Client { get; set;  }
    }
}