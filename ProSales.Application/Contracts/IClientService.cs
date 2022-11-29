using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface IClientService
    {
        Task<RetornoDto> Create(CreateClientDto create);
        Task<RetornoDto> Update(ClientDto update);
        Task<RetornoDto> ToogleAlterStatus(Guid externalId);
        Task<RetornoDto> GetByExternalId(Guid externalId);
        Task<RetornoDto> GetByFullName(string name);
        Task<RetornoDto> GetById(long id);
        Task<RetornoDto> GetAllByQuery(ClientQuery query);
        Task<RetornoDto> GetAllByDocument(DocumentQuery query);
        Task<RetornoDto> GetAllByContact(ContactQuery query);

    }
}