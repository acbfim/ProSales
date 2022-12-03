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
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(20)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string State { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string Street { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string ReferencePoint { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(20)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Country { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(15)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(10)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]+[0-9]*$")]
        public string Number { get; set; }
        public ClientExternal Client { get; set; }
    }
}