using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Dtos
{
    public class InventoryDto
    {
        public Guid ExternalId { get; set; }
        public string Barcode { get; set; }        
        public bool IsActive { get; set; }
    }
}