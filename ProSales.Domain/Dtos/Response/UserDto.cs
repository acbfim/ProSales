using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain.Dtos
{
    public class UserDto
    {
        public Guid ExternalId { get; set; }
        public string FullName { get; set; }
        public string Departamento { get; set; }
        public string ImagemUrlUser { get; set; }

    }
}