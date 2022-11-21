using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Repository.Contracts;

public interface IGlobalRepository
{
    void Add<T>(T entity) where T : class;
    void AddRange<T>(T[] entities) where T : class;
    void Update<T>(T entity) where T : class;
    void UpdateRange<T>(T[] entities) where T : class;
    void Delete<T>(T entity) where T : class;
    void DeleteRange<T>(T[] entities) where T : class;
    Task<bool> SaveChangesAsync();
}
