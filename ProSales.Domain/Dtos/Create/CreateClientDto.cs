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
    public class CreateClientDto
    {
        [StringLength(50)]
        [Required]
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }

        public class CreateContactClientDto
        {
            
        }
    }
}