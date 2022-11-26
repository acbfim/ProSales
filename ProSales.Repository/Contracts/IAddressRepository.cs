using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IAddressRepository
    {
        Task<Address> GetByExternalId(Guid externalId);
        Task<Address> GetById(long id);
        Task<ICollection<Address>> GetAllByQuery(AddressQuery query);
        Task<long> GetCountItems(AddressQuery query);

    }
}