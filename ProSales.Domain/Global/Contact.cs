using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class Contact
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();

        public long ContactTypeId { get; set; }
        public ContactType Type { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Value { get; set; }

        public long ClientId { get; set; }
        public Client Client { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int? UserCreatedId { get; set; }
        public int? UserUpdatedId { get; set; }
        public User? UserCreated { get; set; }
        public User? UserUpdated { get; set; }

        public bool IsActive { get; set; } = true;

    }
}