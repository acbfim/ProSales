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
    public class SaleRepository : ISaleRepository
    {
        private readonly ProSalesContext context;

        public SaleRepository(ProSalesContext context)
        {
            this.context = context;
        }
        public async Task<Sale> GetByExternalId(Guid externalId, bool includeJoins = false)
        {
            IQueryable<Sale> query = this.context.Sale.AsNoTracking();

            if (includeJoins)
                query = query
                    .Include(x => x.Client)
                    .Include(x => x.Seller)
                    .Include(x => x.ProductsSale)
                        .ThenInclude(x => x.Product)
                            .ThenInclude(x => x.Brand)
                    .Include(x => x.ProductsSale)
                        .ThenInclude(x => x.DiscountType);

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<Sale> GetById(long id)
        {
            IQueryable<Sale> query = this.context.Sale.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<ICollection<Sale>> GetAllByQuery(SaleQuery query, bool includeJoins = false)
        {
            var newSkip = query.Skip == 0 ? 0 : (query.Skip * query.Take);

            var result = this.context.Sale.AsQueryable().AsNoTracking()
            .Skip(newSkip)
            .Take((int)query.Take);

            if (includeJoins)
                result = result
                    .Include(x => x.Client)
                    .Include(x => x.Seller)
                    .Include(x => x.CoinType)
                    .Include(x => x.ProductsSale)
                        .ThenInclude(x => x.Product)
                            .ThenInclude(x => x.Brand)
                    .Include(x => x.ProductsSale)
                        .ThenInclude(x => x.DiscountType);

            result = result
            .Filter(query).Sort(query);

            return await result.ToListAsync();
        }

        public async Task<long> GetCountItems(SaleQuery query)
        {
            var result = this.context.Sale.AsQueryable().AsNoTracking();

            result = result
            .Filter(query).Sort(query);

            return result.Count();
        }

        public async Task<ProductSale> GetProductSaleByProductIdAndSaleId(long productId, long SaleId)
        {
            var result = this.context.ProductSale.Where(x => x.ProductId == productId && x.SaleId == SaleId).AsNoTracking();

            return await result.FirstOrDefaultAsync();
        }

        public async Task<ICollection<Sale>> GetAllByClientId(long clientId, bool includeJoins = false)
        {
            IQueryable<Sale> query = this.context.Sale;

            query = query.Where(x => x.ClientId.Equals(clientId)).AsNoTracking();

            if (includeJoins)
                query = query
                    .Include(x => x.Client)
                    .Include(x => x.Seller)
                    .Include(x => x.CoinType)
                    .Include(x => x.ProductsSale)
                        .ThenInclude(x => x.Product)
                            .ThenInclude(x => x.Brand)
                    .Include(x => x.ProductsSale)
                        .ThenInclude(x => x.DiscountType)
                    .Include(x => x.Seller);


            return await query.ToListAsync();
        }

        public async Task<ICollection<Sale>> GetAllByUserId(int userId, bool includeJoins = false)
        {
            IQueryable<Sale> query = this.context.Sale.AsNoTracking();

            query = query.Where(x => x.SellerId == userId);

            if (includeJoins)
                query = query
                    .Include(x => x.Client)
                    .Include(x => x.CoinType)
                    .Include(x => x.ProductsSale)
                        .ThenInclude(x => x.Product)
                            .ThenInclude(x => x.Brand)
                    .Include(x => x.ProductsSale)
                        .ThenInclude(x => x.DiscountType)
                    .Include(x => x.Seller);


            return await query.ToListAsync();
        }


    }
}