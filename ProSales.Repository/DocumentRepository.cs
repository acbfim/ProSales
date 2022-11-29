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
    public class DocumentRepository : IDocumentRepository
    {
        private readonly ProSalesContext context;

        public DocumentRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<Document> GetByExternalId(Guid externalId)
        {
            IQueryable<Document> query = this.context.Document.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Document> GetById(long id)
        {
            IQueryable<Document> query = this.context.Document.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Document> GetByValueAndType(string value, Guid typeDocumentExternalId)
        {
            IQueryable<Document> query = this.context.Document.AsNoTracking();

            return await query.FirstOrDefaultAsync(
                x => x.Value.ToUpper() == value.ToUpper()
                && x.DocumentType.ExternalId == typeDocumentExternalId);
        }

        public async Task<ICollection<Document>> GetAllByQuery(DocumentQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Document.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(DocumentQuery query)
        {
            var result = this.context.Document.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }
    }
}