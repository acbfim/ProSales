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
    public class AddressDto
    {
        public Guid ExternalId { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ReferencePoint { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Number { get; set; }

        public bool IsActive { get; set; }
    }
}