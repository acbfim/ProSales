using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IProductTypeRepository
    {
        Task<ProductType> GetByExternalId(Guid externalId);
        Task<ProductType> GetByName(string name);
        Task<ProductType> GetById(long id);
        Task<ICollection<ProductType>> GetAllByQuery(ProductTypeQuery query);
        Task<long> GetCountItems(ProductTypeQuery query);

    }
}