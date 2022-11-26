using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using Microsoft.EntityFrameworkCore;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace ProSales.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ProSalesContext context;

        public CartRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<Cart> GetByExternalId(Guid externalId)
        {
            IQueryable<Cart> query = this.context.Cart.AsNoTracking();

            query = query.Include(x => x.Client)
                .Include(x => x.ProductsCart)
                    .ThenInclude(x => x.Product);

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Cart> GetById(long id)
        {
            IQueryable<Cart> query = this.context.Cart.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<ICollection<Cart>> GetAllByQuery(CartQuery query)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip*query.Take);

            var result = this.context.Cart.AsQueryable()
            .Skip(newSkip)
            .Take((int)query.Take);

            result = result.Include(x => x.ProductsCart)
                .ThenInclude(x => x.Product);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(CartQuery query)
        {
            var result = this.context.Cart.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }

        public async Task<ProductCart> GetProductCartByProductIdAndCartId(long productId, long cartId)
        {
            var result = this.context.ProductCart.Where(x => x.ProductId == productId && x.CartId == cartId);

            return await result.FirstOrDefaultAsync();
        }
    }
}