using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class Address
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();


        [Column(TypeName = "varchar(30)")]
        public string City { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string State { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Street { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ReferencePoint { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Country { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string ZipCode { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Number { get; set; }


        public long? ClientId { get; set; }
        public Client? Client { get; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int? UserCreatedId { get; set; }
        public int? UserUpdatedId { get; set; }
        public User? UserCreated { get; set; }
        public User? UserUpdated { get; set; }

        public bool IsActive { get; set; } = true;
    }
}