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
    public partial class CreateCartDto
    {

        public ClientExternal? Client { get; set; }

        public ProductExternal? Product { get; set; }

    }


    public partial class CartDtoAddProduct
    {
        public Guid ExternalId { get; set; }
        public ICollection<ProductExternal> Products { get; set; }

    }

}