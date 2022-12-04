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
    public class CreateProductSaleDto
    {
        public ProductExternal Product { get; set; }
        public SaleExternal Sale { get; set; }
        
    }

    public class UpdateDiscountProductSaleDto
    {
        public ProductExternal Product { get; set; }
        public SaleExternal Sale { get; set; }
        public DiscountTypeExternal DiscountType { get; set; }
        public double Discount { get; set; } = 0.0;
    }


}