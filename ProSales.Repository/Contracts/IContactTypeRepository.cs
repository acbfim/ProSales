using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IContactTypeRepository
    {
        Task<ContactType> GetByExternalId(Guid externalId);
        Task<ContactType> GetByName(string name);
        Task<ContactType> GetById(long id);
        Task<ICollection<ContactType>> GetAllByQuery(ContactTypeQuery query);
        Task<long> GetCountItems(ContactTypeQuery query);

    }
}