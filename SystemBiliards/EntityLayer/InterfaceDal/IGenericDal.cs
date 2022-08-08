using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {

        Task InsertAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task< List<T>> GetListAllAsync();
        Task< T> GetByIdAsync(int id);
        Task< List<T>> GetListAllAsync(Expression<Func<T, bool>> expression);


       
    }
}
