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
        [StringLength(30)]
        public string City { get; set; }

        [Column(TypeName = "varchar(20)")]
        [StringLength(20)]
        public string State { get; set; }

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Street { get; set; }

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string ReferencePoint { get; set; }

        [Column(TypeName = "varchar(20)")]
        [StringLength(20)]
        public string Country { get; set; }

        [Column(TypeName = "varchar(15)")]
        [StringLength(15)]
        public string ZipCode { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public User? UserCreated { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public User? UserUpdated { get; set; }
    }
}