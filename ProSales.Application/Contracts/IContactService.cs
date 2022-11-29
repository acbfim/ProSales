using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface IContactService
    {
        Task<RetornoDto> Create(CreateContactDto create);
        Task<RetornoDto> Update(ContactDto update);
        Task<RetornoDto> ToogleAlterStatus(Guid externalId);
        Task<RetornoDto> GetByExternalId(Guid externalId);
        Task<RetornoDto> GetByValueAndTypeContact(string value, Guid contactTypeExternalId);
        Task<RetornoDto> GetById(long id);
        Task<RetornoDto> GetAllByQuery(ContactQuery query);

    }
}