using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using Microsoft.EntityFrameworkCore;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace ProSales.Repository
{
    public class ProductSaleRepository : IProductSaleRepository
    {
        private readonly ProSalesContext context;

        public ProductSaleRepository(ProSalesContext context )
        {
            this.context = context;
        }

        public async Task<ProductSale> GetByProductIdAndSaleId(long productId, long saleId)
        {
            IQueryable<ProductSale> query = this.context.ProductSale.AsNoTracking();

            query = query.Where(x => x.ProductId == productId && x.SaleId == saleId);

            return query.FirstOrDefault();
        }
    }
}