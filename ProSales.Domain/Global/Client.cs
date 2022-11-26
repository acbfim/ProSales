using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class Client
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();
        

        [Column(TypeName = "varchar(50)")]
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Contact>? Contacts { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Document>? Documents { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int? UserCreatedId { get; set; }
        public int? UserUpdatedId { get; set; }
        public User? UserCreated { get; set; }
        public User? UserUpdated { get; set; }

        public bool IsActive { get; set; }
    }
}