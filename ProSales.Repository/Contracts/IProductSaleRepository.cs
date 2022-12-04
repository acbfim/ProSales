using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IProductSaleRepository
    {
        Task<ProductSale> GetByProductIdAndSaleId(long productId, long saleId);
    }
}