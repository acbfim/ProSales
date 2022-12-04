using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ProSales.Domain.Global;

namespace ProSales.Domain.Dtos
{
    public class CreateSaleDto
    {
        public ClientExternal? Client { get; set; }
    }

    public class SaleDtoAddProduct
    {
        public Guid ExternalId { get; set; }
        public ProductExternal Product { get; set; }
    }
}