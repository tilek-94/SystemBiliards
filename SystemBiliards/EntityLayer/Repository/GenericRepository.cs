using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SystemBiliards.Infrastucture;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        public void Delete(T entity)
        {
            using ApplicationContext c = new();
            _ = c.Remove(entity);
            _ = c.SaveChanges();
        }

        public T GetById(int id)
        {
            using ApplicationContext c = new();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using ApplicationContext c = new();
            return c.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using ApplicationContext c = new();
            _ = c.Add(entity);
            _ = c.SaveChanges();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using ApplicationContext c = new();
            return c.Set<T>()
                .Where(filter)
                .ToList();
        }

        public void Update(T entity)
        {
            using ApplicationContext c = new();
            _ = c.Update(entity);
            _ = c.SaveChanges();
        }

        public Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetListAllAsync()
        {
            using ApplicationContext c = new();
            return await c.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using ApplicationContext c = new();
            return await c.Set<T>().FindAsync(id);
        }

        public Task<List<T>> GetListAllAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
