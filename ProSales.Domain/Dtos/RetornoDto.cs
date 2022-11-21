using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProSales.Domain.Dtos
{
    public class RetornoDto
    {
        public string Message { get; set; } = "Erro ao realizar ação";
        public bool Success { get; set; } = false;
        public Object Object { get; set; }
        public int StatusCode { get; set; }
    }
}