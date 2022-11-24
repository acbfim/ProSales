using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class Brand
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        

        [Column(TypeName = "varchar(20)")]
        [StringLength(20)]
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}