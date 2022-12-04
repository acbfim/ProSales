using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;

namespace ProSales.Repository.Contracts
{
    public interface IUserManagerRepository
    {
        Task<User> GetByExternalId(Guid externalId);
    }
}