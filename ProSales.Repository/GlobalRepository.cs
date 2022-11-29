using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace ProSales.Repository;

public class GlobalRepository : IGlobalRepository
{
    private readonly ProSalesContext _context;

    public GlobalRepository(ProSalesContext Context)
    {
        _context = Context;
    }


    public void Add<T>(T entity) where T : class
    {
        _context.AddAsync(entity);
    }

    public void AddRange<T>(IEnumerable<T> entities) where T : class
    {
        _context.AddRangeAsync(entities);
    }

    public void Delete<T>(T entity) where T : class
    {
        _context.Remove(entity);
    }

    public void DeleteRange<T>(IEnumerable<T> entities) where T : class
    {
        _context.RemoveRange(entities);
    }

    public void Update<T>(T entity) where T : class
    {
        _context.Update(entity);
    }

    public void UpdateRange<T>(IEnumerable<T> entities) where T : class
    {
        _context.UpdateRange(entities);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync()) > 0;
    }

    
}
