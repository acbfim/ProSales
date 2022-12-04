using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using Microsoft.EntityFrameworkCore;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace ProSales.Repository
{
    public class UserManagerRepository : IUserManagerRepository
    {
        private readonly ProSalesContext context;

        public UserManagerRepository(ProSalesContext context )
        {
            this.context = context;
        }

        public async Task<User> GetByExternalId(Guid externalId)
        {
            IQueryable<User> query = this.context.Users.AsNoTracking();

            query = query.Where(x => x.ExternalId == externalId);

            return query.FirstOrDefault();
        }
    }
}