using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface ISpecificationRepository
    {
        Task<Specification> GetByExternalId(Guid externalId);
        Task<ICollection<Specification>> GetAllByKey(string key);
        Task<ICollection<Specification>> GetAllByValue(string value);
        Task<ICollection<Specification>> GetAllByProductId(long productId);
        Task<Specification> GetById(long id);
        Task<ICollection<Specification>> GetAllByQuery(SpecificationQuery query);
        Task<long> GetCountItems(SpecificationQuery query);

    }
}