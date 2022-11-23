using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;

namespace ProSales.Repository.Contracts
{
    public interface ICalculationTypeRepository
    {
        Task<CalculationType> GetByExternalId(Guid externalId);
        Task<CalculationType> GetByName(string name);
        Task<CalculationType> GetById(long id);

    }
}