using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Dtos
{
    public class CreateBrandDto
    {
        [StringLength(20)]
        [Required]
        public string Name { get; set; }
    }
}