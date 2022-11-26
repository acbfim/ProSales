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
    public class CreateAddressDto
    {

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(30)]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(20)]
        public string State { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(50)]
        public string Street { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100)]
        public string ReferencePoint { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(20)]
        public string Country { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(15)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(10)]
        public string Number { get; set; }

        public ClientDtt Client { get; set; }

        public partial class ClientDtt {
            public Guid ExternalId { get; set; }
        }

        
    }
}