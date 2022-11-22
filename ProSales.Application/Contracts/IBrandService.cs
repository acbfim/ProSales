using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;

namespace ProSales.Application.Contracts
{
    public interface IBrandService
    {
        Task<RetornoDto> CreateBrand(CreateBrandDto brand);
        Task<RetornoDto> UpdateBrand(BrandDto brand);
        Task<RetornoDto> ToggleDesactivateBrand(Guid externalId);
        Task<RetornoDto> GetBrandByExternalId(Guid externalId);
        Task<RetornoDto> GetBrandByName(string name);
        Task<RetornoDto> GetBrandById(long id);
        Task<RetornoDto> GetAllBrandByQuery(BrandQuery query);

    }
}