using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IProductRepository
    {
        Task<Product> GetByExternalId(Guid externalId);
        Task<Product> GetByName(string name);
        Task<Product> GetById(long id);
        Task<ICollection<Product>> GetAllByQuery(ProductQuery query);
        Task<long> GetCountItems(ProductQuery query);

    }
}