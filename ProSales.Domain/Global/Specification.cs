using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Global
{
    public class Specification
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();

        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        public string Key { get; set; }

        [Column(TypeName = "varchar(1000)")]
        [StringLength(1000)]
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}