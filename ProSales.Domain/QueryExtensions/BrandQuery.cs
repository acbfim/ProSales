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
    public class BrandQuery : ICustomQueryable, IQueryPaging, IQuerySort
    {
        [QueryOperator(Operator = WhereOperator.Contains)]
        //[QueryOperator(Operator = WhereOperator.GreaterThanOrEqualTo)]...
        public string? Name { get; set; }
        public Guid? ExternalId { get; set; }
        public int? Limit { get; set; } = 50;
        public int? Offset { get; set; }
        public string? Sort { get; set; }
    }
}