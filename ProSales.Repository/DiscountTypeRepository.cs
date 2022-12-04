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
    public class DiscountTypeRepository : IDiscountTypeRepository
    {
        private readonly ProSalesContext context;

        public DiscountTypeRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<DiscountType> GetByExternalId(Guid externalId)
        {
            IQueryable<DiscountType> query = this.context.DiscountType.AsNoTracking();

            query = query.Include(x => x.CalculationType);

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<DiscountType> GetById(long id)
        {
            IQueryable<DiscountType> query = this.context.DiscountType.AsNoTracking();

            query = query.Include(x => x.CalculationType);

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<DiscountType> GetByName(string name)
        {
            IQueryable<DiscountType> query = this.context.DiscountType.AsNoTracking();

            query = query.Include(x => x.CalculationType);

            return await query.FirstOrDefaultAsync(x => x.Name.ToUpper() == name.ToUpper());
        }

        public async Task<ICollection<DiscountType>> GetAllByQuery(DiscountTypeQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.DiscountType.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result.Include(x => x.CalculationType);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(DiscountTypeQuery query)
        {
            var result = this.context.DiscountType.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}