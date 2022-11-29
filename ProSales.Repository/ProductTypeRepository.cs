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
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly ProSalesContext context;

        public ProductTypeRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<ProductType> GetByExternalId(Guid externalId)
        {
            IQueryable<ProductType> query = this.context.ProductType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<ProductType> GetById(long id)
        {
            IQueryable<ProductType> query = this.context.ProductType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ProductType> GetByName(string name)
        {
            IQueryable<ProductType> query = this.context.ProductType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Name.ToUpper() == name.ToUpper());
        }

        public async Task<ICollection<ProductType>> GetAllByQuery(ProductTypeQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.ProductType.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(ProductTypeQuery query)
        {
            var result = this.context.ProductType.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}