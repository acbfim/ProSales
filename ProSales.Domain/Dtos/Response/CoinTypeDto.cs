using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Dtos
{
    public class CoinTypeDto
    {
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }

    }
}