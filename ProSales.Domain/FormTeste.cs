using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Domain
{
    public class FormTeste
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public int? FormTesteId { get; set; }
        public ICollection<FormTeste> Respostas { get; set; }
    }
}