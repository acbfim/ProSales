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
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Name { get; set; }
        public double Value { get; set; } = 0.0;

        public long? CalculationTypeId { get; set; }
        public CalculationType? CalculationType { get; set; }

        public User? UserCreated { get; set; }
        public User? UserUpdated { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int? UserCreatedId { get; set; }
        public int? UserUpdatedId { get; set; }

        public bool IsActive { get; set; } = true;
        public bool InternalProperty { get; set; } = false;
    }
}