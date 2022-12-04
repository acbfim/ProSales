using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface ISaleRepository
    {
        Task<Sale> GetByExternalId(Guid externalId, bool includeJoins = false);
        Task<ICollection<Sale>> GetAllByClientId(long clientId, bool includeJoins = false);
        Task<ICollection<Sale>> GetAllByUserId(int userId, bool includeJoins = false);
        Task<Sale> GetById(long id);
        Task<ProductSale> GetProductSaleByProductIdAndSaleId(long productId, long SaleId);
        Task<ICollection<Sale>> GetAllByQuery(SaleQuery query, bool includeJoins = false);
        Task<long> GetCountItems(SaleQuery query);

    }
}