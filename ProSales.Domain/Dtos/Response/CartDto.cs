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
    public partial class CartDto
    {
        public Guid ExternalId { get; set; }

        public DateTime CreatedAt { get; set; } 
        public ICollection<ProductCartDto> ProductsCart { get; set; }

        public bool IsActive { get; set; }
    }

    

    
}