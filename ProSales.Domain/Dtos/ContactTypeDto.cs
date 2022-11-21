using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Dtos
{
    public class ContactTypeDto
    {
        public Guid ExternalId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string TypeName { get; set; }
    }
}