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
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace ProSales.Repository
{
    public class CalculationTypeRepository : ICalculationTypeRepository
    {
        private readonly ProSalesContext context;

        public CalculationTypeRepository(ProSalesContext context )
        {
            this.context = context;
        }
        public async Task<CalculationType> GetByExternalId(Guid externalId)
        {
            IQueryable<CalculationType> query = this.context.CalculationType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.ExternalId == externalId);
        }

        public async Task<CalculationType> GetById(long id)
        {
            IQueryable<CalculationType> query = this.context.CalculationType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<CalculationType> GetByName(string name)
        {
            IQueryable<CalculationType> query = this.context.CalculationType.AsNoTracking();

            return await query.FirstOrDefaultAsync(x => x.Name.ToUpper() == name.ToUpper());
        }

    }
}