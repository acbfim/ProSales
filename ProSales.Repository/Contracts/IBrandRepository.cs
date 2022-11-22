using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IBrandRepository
    {
        Task<Brand> GetBrandByExternalId(Guid externalId);
        Task<Brand> GetBrandByName(string name);
        Task<Brand> GetBrandById(long id);
        Task<ICollection<Brand>> GetAllBrandByQuery(BrandQuery query);

    }
}