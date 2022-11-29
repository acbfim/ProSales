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
    public class ContactRepository : IContactRepository
    {
        private readonly ProSalesContext context;

        public ContactRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<Contact> GetByExternalId(Guid externalId)
        {
            IQueryable<Contact> query = this.context.Contact.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Contact> GetById(long id)
        {
            IQueryable<Contact> query = this.context.Contact.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Contact> GetByValueAndType(string value, Guid typeContactExternalId)
        {
            IQueryable<Contact> query = this.context.Contact.AsNoTracking();

            return await query.FirstOrDefaultAsync(
                x => x.Value.ToUpper() == value.ToUpper()
                && x.ContactType.ExternalId == typeContactExternalId);
        }

        public async Task<ICollection<Contact>> GetAllByQuery(ContactQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Contact.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(ContactQuery query)
        {
            var result = this.context.Contact.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}