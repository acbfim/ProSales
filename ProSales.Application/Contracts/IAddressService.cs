using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface IAddressService
    {
        Task<RetornoDto> Create(CreateAddressDto create);
        Task<RetornoDto> Update(AddressDto update);
        Task<RetornoDto> ToogleAlterStatus(Guid externalId);
        Task<RetornoDto> GetByExternalId(Guid externalId);
        Task<RetornoDto> GetById(long id);
        Task<RetornoDto> GetAllByQuery(AddressQuery query);

    }
}