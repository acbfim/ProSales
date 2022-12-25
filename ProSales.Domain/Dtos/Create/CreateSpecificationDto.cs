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
    public class CreateSpecificationDto
    {

        [Required(ErrorMessage ="O campo é obrigatório")]
        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string Key { get; set; }

        [Required(ErrorMessage ="O campo é obrigatório")]
        [StringLength(1000)]
        public string Value { get; set; }
        public ProductExternal Product { get; set; }
    }
}