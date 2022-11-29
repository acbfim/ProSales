using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Dtos
{
    public class CreateContactDto
    {
        [StringLength(50)]
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage ="Informe apenas números entre 0 e 9")]
        public string Value { get; set; }
        public CreateContactContactTypeDto ContactType { get; set; }
        public CreateContactClientDto Client { get; set; }


    }
    public class CreateContactClientDto
    {
        public Guid ExternalId { get; set; }
    }

    public class CreateContactContactTypeDto
    {
        public Guid ExternalId { get; set; }
    }
}