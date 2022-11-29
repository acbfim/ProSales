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
    public class BrandRepository : IBrandRepository
    {
        private readonly ProSalesContext context;

        public BrandRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<Brand> GetBrandByExternalId(Guid externalId)
        {
            IQueryable<Brand> query = this.context.Brand.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Brand> GetBrandById(long id)
        {
            IQueryable<Brand> query = this.context.Brand.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Brand> GetBrandByName(string name)
        {
            IQueryable<Brand> query = this.context.Brand.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Name.ToUpper() == name.ToUpper());
        }

        public async Task<ICollection<Brand>> GetAllBrandByQuery(BrandQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Brand.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(BrandQuery query)
        {
            var result = this.context.Brand.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}