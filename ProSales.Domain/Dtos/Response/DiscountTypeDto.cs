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
    public class DiscountTypeDto
    {
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public double Value { get; set; } = 0.0;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CalculationTypeDto? CalculationType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid CalculationTypeExternalId { get; set; }
        public bool IsActive { get; set; }
    }
}