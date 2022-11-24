using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Dtos
{
    public class BrandDto
    {
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool InternalProperty { get; set; }
    }
}