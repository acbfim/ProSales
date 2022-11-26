using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IClientRepository
    {
        Task<Client> GetByExternalId(Guid externalId);
        Task<Client> GetByFullName(string fullName);
        Task<Client> GetById(long id);
        Task<ICollection<Client>> GetAllByQuery(ClientQuery query);
        Task<long> GetCountItems(ClientQuery query);

    }
}