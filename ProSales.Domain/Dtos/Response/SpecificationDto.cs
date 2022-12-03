using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Dtos
{
    public class SpecificationDto
    {
        public Guid ExternalId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

    }
}