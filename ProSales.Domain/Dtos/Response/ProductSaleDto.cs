using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Dtos
{
    public class ProductSaleDto
    {
        public Guid ExternalId { get; set; }
        public ProductDto Product { get; set; }

    }
}