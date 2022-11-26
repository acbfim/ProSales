using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class ProductOrder
    {
       public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();

        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int? UserCreatedId { get; set; }
        public User? UserCreated { get; set; }
    }
}