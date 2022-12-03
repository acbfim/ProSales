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
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ProSalesContext context;

        public InventoryRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<Inventory> GetByExternalId(Guid externalId)
        {
            IQueryable<Inventory> query = this.context.Inventory.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Inventory> GetById(long id)
        {
            IQueryable<Inventory> query = this.context.Inventory.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Inventory>> GetAllByQuery(InventoryQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Inventory.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(InventoryQuery query)
        {
            var result = this.context.Inventory.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }

        public async Task<ICollection<Inventory>> GetByProductId(InventoryQuery query, long productId)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Inventory.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result.Where(x => x.ProductId == productId);

            return await result.ToListAsync();
        }

      
    }
}