using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Dtos
{
    public class CreateOrderDto
    {
        public Guid ExternalId { get; set; }
        public ClientExternal Client { get; set; }
    }
}