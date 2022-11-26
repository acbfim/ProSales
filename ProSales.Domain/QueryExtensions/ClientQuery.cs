using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Dtos
{
    public class ClientQuery : ICustomQueryable, IQuerySort
    {
        [QueryOperator(Operator = WhereOperator.Contains)]
        //[QueryOperator(Operator = WhereOperator.GreaterThanOrEqualTo)]...
        public string? FullName { get; set; }
        public Guid? ExternalId { get; set; }
        public string? Sort { get; set; }
        public int Skip { get; set; } = 0;
        public int Take { get; set; } = 50;
    }
}