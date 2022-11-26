using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface ICartRepository
    {
        Task<Cart> GetByExternalId(Guid externalId);
        Task<Cart> GetById(long id);
        Task<ProductCart> GetProductCartByProductIdAndCartId(long productId, long cartId);
        Task<ICollection<Cart>> GetAllByQuery(CartQuery query);
        Task<long> GetCountItems(CartQuery query);

    }
}