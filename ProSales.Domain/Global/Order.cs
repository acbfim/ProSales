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

        public double Amount { get; set; }

        public long ClientId { get; set; }
        public Client? Client { get; set; }
        public long CoinTypeId { get; set; }
        public CoinType CoinType { get; set; }

        public ICollection<ProductOrder>? ProductsOrder { get; set; }
        




    }
}