using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface ICartService
    {
        Task<RetornoDto> Create(CreateCartDto create);
        Task<RetornoDto> AddProduct(CartDtoAddProduct cart);
        Task<RetornoDto> RemoveProduct(CartDtoAddProduct cart);

        Task<RetornoDto> GetByExternalId(Guid externalId);
        Task<RetornoDto> GetById(long id);
        Task<RetornoDto> GetAllByQuery(CartQuery query);

    }
}