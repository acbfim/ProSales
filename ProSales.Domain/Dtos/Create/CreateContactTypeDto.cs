using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Dtos
{
    public class CreateContactTypeDto
    {
        [StringLength(50)]
        [Required(ErrorMessage ="O campo é obrigatório")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string Name { get; set; }
    }
}