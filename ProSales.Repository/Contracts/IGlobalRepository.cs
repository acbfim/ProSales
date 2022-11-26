using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProSales.Repository.Contracts;

public interface IGlobalRepository
{
    void Add<T>(T entity) where T : class;
    void AddRange<T>(IEnumerable<T> entities) where T : class;
    void Update<T>(T entity) where T : class;
    void UpdateRange<T>(IEnumerable<T> entities) where T : class;
    void Delete<T>(T entity) where T : class;
    void DeleteRange<T>(IEnumerable<T> entities) where T : class;
    Task<bool> SaveChangesAsync();
}
