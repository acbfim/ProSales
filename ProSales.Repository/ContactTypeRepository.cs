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
    public class ContactTypeRepository : IContactTypeRepository
    {
        private readonly ProSalesContext context;

        public ContactTypeRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<ContactType> GetByExternalId(Guid externalId)
        {
            IQueryable<ContactType> query = this.context.ContactType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<ContactType> GetById(long id)
        {
            IQueryable<ContactType> query = this.context.ContactType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ContactType> GetByName(string name)
        {
            IQueryable<ContactType> query = this.context.ContactType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Name.ToUpper() == name.ToUpper());
        }

        public async Task<ICollection<ContactType>> GetAllByQuery(ContactTypeQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.ContactType.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(ContactTypeQuery query)
        {
            var result = this.context.ContactType.AsQueryable();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}