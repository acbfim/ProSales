using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface IInventoryService
    {
        Task<RetornoDto> Create(CreateInventoryDto create);
        Task<RetornoDto> Update(InventoryDto update);
        Task<RetornoDto> ToogleAlterStatus(Guid externalId);
        Task<RetornoDto> GetByExternalId(Guid externalId);
        Task<RetornoDto> GetById(long id);
        Task<RetornoDto> GetAllByQuery(InventoryQuery query);
        Task<RetornoDto> GetAllByProductId(InventoryQuery query, Guid productExternalId);

    }
}