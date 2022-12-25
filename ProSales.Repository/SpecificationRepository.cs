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
    public class SpecificationRepository : ISpecificationRepository
    {
        private readonly ProSalesContext context;

        public SpecificationRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<Specification> GetByExternalId(Guid externalId)
        {
            IQueryable<Specification> query = this.context.Specification.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Specification> GetById(long id)
        {
            IQueryable<Specification> query = this.context.Specification.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Specification>> GetAllByQuery(SpecificationQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Specification.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(SpecificationQuery query)
        {
            var result = this.context.Specification.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }

        public async Task<ICollection<Specification>> GetAllByKey(string key)
        {
            var query = this.context.Specification.AsQueryable().AsNoTracking();

            query = query.Where(x => x.Key.Contains(key));

            return await query.ToArrayAsync();
        }

        public async Task<ICollection<Specification>> GetAllByValue(string value)
        {
            var query = this.context.Specification.AsQueryable().AsNoTracking();

            query = query.Where(x => x.Value.Contains(value));

            return await query.ToArrayAsync();
        }

        public async Task<ICollection<Specification>> GetAllByProductId(long productId)
        {
            var query = this.context.Specification.AsQueryable().AsNoTracking();

            query = query.Where(x => x.ProductId == (productId));

            return await query.ToArrayAsync();
        }
    }
}