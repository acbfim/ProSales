using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IDocumentTypeRepository
    {
        Task<DocumentType> GetByExternalId(Guid externalId);
        Task<DocumentType> GetByName(string name);
        Task<DocumentType> GetById(long id);
        Task<ICollection<DocumentType>> GetAllByQuery(DocumentTypeQuery query);
        Task<long> GetCountItems(DocumentTypeQuery query);

    }
}