using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface IDocumentService
    {
        Task<RetornoDto> Create(CreateDocumentDto create);
        Task<RetornoDto> Update(DocumentDto update);
        Task<RetornoDto> ToogleAlterStatus(Guid externalId);
        Task<RetornoDto> GetByExternalId(Guid externalId);
        Task<RetornoDto> GetByValueAndTypeDocument(string value, Guid DocumentTypeExternalId);
        Task<RetornoDto> GetById(long id);
        Task<RetornoDto> GetAllByQuery(DocumentQuery query);

    }
}