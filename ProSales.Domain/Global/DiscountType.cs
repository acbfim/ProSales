using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Global
{
    public class DiscountType
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();

        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string TypeName { get; set; }
        public double Value { get; set; } = 0.0;
        public long? TypeCalculatioId { get; set; }
        public TypeCalculation? TypeCalculation { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public User? UserCreated { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public User? UserUpdated { get; set; }
    }
}