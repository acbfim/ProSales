using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class Document
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();


        [Column(TypeName = "varchar(100)")]
        public string Value { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? UrlLocation { get; set; }

        [Column(TypeName = "varchar(130)")]
        public string? FileName { get; set; }

        public long DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }

        public User? UserCreated { get; set; }
        public User? UserUpdated { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int? UserCreatedId { get; set; }
        public int? UserUpdatedId { get; set; }

        public bool IsActive { get; set; } = true;
    }
}