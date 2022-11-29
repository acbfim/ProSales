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
    public partial class DocumentDto
    {
        public Guid ExternalId { get; set; }

        public string Value { get; set; }

        public string? UrlLocation { get; set; }

        public string? FileName { get; set; }

        public DocumentTypeDto? DocumentType { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }
    }




}