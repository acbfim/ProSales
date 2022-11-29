using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class ContactType
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        public bool InternalProperty { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public User? UserCreated { get; set; }
        public User? UserUpdated { get; set; }
        public int? UserCreatedId { get; set; }
        public int? UserUpdatedId { get; set; }

    }
}