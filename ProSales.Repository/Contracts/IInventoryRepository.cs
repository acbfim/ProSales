using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IInventoryRepository
    {
        Task<Inventory> GetByExternalId(Guid externalId);
        Task<Inventory> GetById(long id);
        Task<ICollection<Inventory>> GetByProductId(InventoryQuery query, long productId);
        Task<ICollection<Inventory>> GetAllByQuery(InventoryQuery query);
        Task<long> GetCountItems(InventoryQuery query);

    }
}