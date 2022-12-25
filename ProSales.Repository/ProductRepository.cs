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
    public class ProductRepository : IProductRepository
    {
        private readonly ProSalesContext context;

        public ProductRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<Product> GetByExternalId(Guid externalId)
        {
            IQueryable<Product> query = this.context.Product.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Product> GetById(long id)
        {
            IQueryable<Product> query = this.context.Product.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Product> GetByName(string name)
        {
            IQueryable<Product> query = this.context.Product.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Name.ToUpper() == name.ToUpper());
        }

        public async Task<ICollection<Product>> GetAllByQuery(ProductQuery query, bool includeJoins = false)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Product.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            if (includeJoins)
            result = result
                .Include(x => x.Specifications)
                .Include(x => x.Brand)
                .Include(x => x.ProductType)
                .Include(x => x.DiscountType)
                    .ThenInclude(x => x.CalculationType);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(ProductQuery query)
        {
            var result = this.context.Product.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}