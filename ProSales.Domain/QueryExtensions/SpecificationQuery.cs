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
using ProSales.Domain.Global;
using ProSales.Domain.Identity;

namespace ProSales.Domain.Dtos
{
    public class SpecificationQuery : ICustomQueryable, IQuerySort
    {
        [QueryOperator(Operator = WhereOperator.Contains)]
        public Guid? Key { get; set; }

        [QueryOperator(Operator = WhereOperator.Contains)]
        public Guid? Value { get; set; }
        public string? Sort { get; set; }
        public int Skip { get; set; } = 0;
        public int Take { get; set; } = 50;
    }
}