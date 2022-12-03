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
    public class CreateProductDto
    {

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string Name { get; set; }

        [StringLength(20)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        public double Price { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        public double? Discount { get; set; }
        public DiscountTypeExternal? DiscountType { get; set; }
        public ProductTypeExternal ProductType { get; set; }
        public BrandExternal Brand { get; set; }


    }
}