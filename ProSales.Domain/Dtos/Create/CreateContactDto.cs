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
        public string Value { get; set; }
        public ContactTypeDto ContactType { get; set; }
        public ClientDto Client { get; set; }
    }
}