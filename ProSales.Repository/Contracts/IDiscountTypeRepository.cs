using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface IDiscountTypeRepository
    {
        Task<DiscountType> GetByExternalId(Guid externalId);
        Task<DiscountType> GetByName(string name);
        Task<DiscountType> GetById(long id);
        Task<ICollection<DiscountType>> GetAllByQuery(DiscountTypeQuery query);
        Task<long> GetCountItems(DiscountTypeQuery query);

    }
}