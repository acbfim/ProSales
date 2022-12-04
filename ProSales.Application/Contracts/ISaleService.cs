using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface ISaleService
    {
        Task<RetornoDto> Create(CreateSaleDto create);
        Task<RetornoDto> AddProduct(CreateProductSaleDto Sale);
        Task<RetornoDto> UpdateDiscountProduct(UpdateDiscountProductSaleDto productSale);
        Task<RetornoDto> RemoveProduct(CreateProductSaleDto productSale);

        Task<RetornoDto> GetByExternalId(Guid externalId, bool includeJoins = false);
        Task<RetornoDto> GetById(long id);

        Task<RetornoDto> GetAllByQuery(SaleQuery query, bool includeJoins = false);
        Task<RetornoDto> GetAllByClientExternalId(Guid clientExternalId, bool includeJoins = false);
        Task<RetornoDto> GetAllByUserExternalId(Guid userExternalId, bool includeJoins = false);



    }
}