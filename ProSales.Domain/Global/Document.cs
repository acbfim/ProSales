using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Global
{
    public class Document
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();
        public DocumentType Type { get; set; }

        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        public string Value { get; set; }

        [Column(TypeName = "varchar(300)")]
        [StringLength(300)]
        public string? UrlLocation { get; set; }

        [Column(TypeName = "varchar(130)")]
        [StringLength(300)]
        public string? FileName { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool InternalProperty { get; set; } = false;
    }
}