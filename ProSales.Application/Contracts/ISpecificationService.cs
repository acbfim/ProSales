using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface ISpecificationService
    {
        Task<RetornoDto> Create(CreateSpecificationDto create);
        Task<RetornoDto> Update(SpecificationDto update);
        Task<RetornoDto> Delete(Guid externalId);
        Task<RetornoDto> GetByExternalId(Guid externalId);
        Task<RetornoDto> GetAllByKey(string key);
        Task<RetornoDto> GetAllByValue(string value);
        Task<RetornoDto> GetAllByProductExternalId(Guid productExternalId);
        Task<RetornoDto> GetById(long id);
        Task<RetornoDto> GetAllByQuery(SpecificationQuery query);

    }
}