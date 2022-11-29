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
    public partial class ClientDto
    {
        public Guid ExternalId { get; set; }
        public string? FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<ContactDto>? Contacts { get; set; }
        public ICollection<AddressDto>? Addresses { get; set; }
        public ICollection<DocumentDto>? Documents { get; set; }

        public bool IsActive { get; set; }
    }

    
}