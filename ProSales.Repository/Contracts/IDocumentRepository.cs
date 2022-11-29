using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IDocumentRepository
    {
        Task<Document> GetByExternalId(Guid externalId);
        Task<Document> GetByValueAndType(string value, Guid typeDocumentExternalId);
        Task<Document> GetById(long id);
        Task<ICollection<Document>> GetAllByQuery(DocumentQuery query);
        Task<long> GetCountItems(DocumentQuery query);

    }
}