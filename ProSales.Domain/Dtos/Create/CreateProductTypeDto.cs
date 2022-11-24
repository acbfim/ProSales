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
    public class CreateProductTypeDto
    {

        [Required(ErrorMessage ="O campo é obrigatório")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}