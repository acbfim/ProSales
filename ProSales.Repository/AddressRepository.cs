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
    public class AddressRepository : IAddressRepository
    {
        private readonly ProSalesContext context;

        public AddressRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<Address> GetByExternalId(Guid externalId)
        {
            IQueryable<Address> query = this.context.Address.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Address> GetById(long id)
        {
            IQueryable<Address> query = this.context.Address.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<ICollection<Address>> GetAllByQuery(AddressQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Address.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(AddressQuery query)
        {
            var result = this.context.Address.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}