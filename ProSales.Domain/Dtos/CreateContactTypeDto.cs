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
        [MinLength(5,ErrorMessage ="Informe um contato com mais de 5 caracteres")]
        [Required(ErrorMessage ="O campo é requerido")]
        public string TypeName { get; set; }
    }
}