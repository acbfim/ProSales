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
    public class CreateDiscountTypeDto
    {

        [Required(ErrorMessage ="O campo é obrigatório")]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string Name { get; set; }

        [Required(ErrorMessage ="O campo é obrigatório")]
        public double Value { get; set; } = 0.0;

        [Required(ErrorMessage ="O campo é obrigatório")]
        public Guid CalculationTypeExternalId { get; set; }
    }
}