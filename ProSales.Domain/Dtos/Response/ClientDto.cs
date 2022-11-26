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
        public ICollection<Contact>? Contacts { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Document>? Documents { get; set; }

        public bool IsActive { get; set; }
    }

    
}