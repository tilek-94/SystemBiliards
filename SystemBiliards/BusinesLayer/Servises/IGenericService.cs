using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        Task InsertAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<List<T>> GetListAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListAllAsync(Expression<Func<T, bool>> expression);
    }
}
