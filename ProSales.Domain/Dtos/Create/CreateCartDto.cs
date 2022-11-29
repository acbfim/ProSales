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

        public ClientDtoAddCart? Client { get; set; }

        public ProductDtoAddCart? Product { get; set; }

    }

    public class ProductDtoAddCart
    {
        public Guid ExternalId { get; set; }
    }

    public class ClientDtoAddCart
    {
        public Guid ExternalId { get; set; }
    }

    public partial class CartDtoAddProduct
    {
        public Guid ExternalId { get; set; }
        public ICollection<ProductDtoAddCart> Products { get; set; }

    }

}