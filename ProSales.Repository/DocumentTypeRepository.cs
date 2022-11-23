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
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly ProSalesContext context;

        public DocumentTypeRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<DocumentType> GetByExternalId(Guid externalId)
        {
            IQueryable<DocumentType> query = this.context.DocumentType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<DocumentType> GetById(long id)
        {
            IQueryable<DocumentType> query = this.context.DocumentType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<DocumentType> GetByName(string name)
        {
            IQueryable<DocumentType> query = this.context.DocumentType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Name.ToUpper() == name.ToUpper());
        }

        public async Task<ICollection<DocumentType>> GetAllByQuery(DocumentTypeQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.DocumentType.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(DocumentTypeQuery query)
        {
            var result = this.context.DocumentType.AsQueryable();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}