using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IContactRepository
    {
        Task<Contact> GetByExternalId(Guid externalId);
        Task<Contact> GetByValueAndType(string value, Guid typeContactExternalId);
        Task<Contact> GetById(long id);
        Task<ICollection<Contact>> GetAllByQuery(ContactQuery query);
        Task<long> GetCountItems(ContactQuery query);

    }
}