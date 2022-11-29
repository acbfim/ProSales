using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface IContactTypeService
    {
        Task<RetornoDto> Create(CreateContactTypeDto create);
        Task<RetornoDto> Update(ContactTypeDto update);
        Task<RetornoDto> ToogleAlterStatus(Guid externalId);
        Task<RetornoDto> GetByExternalId(Guid externalId);
        Task<RetornoDto> GetByName(string name);
        Task<RetornoDto> GetById(long id);
        Task<RetornoDto> GetAllByQuery(ContactTypeQuery query);

    }
}