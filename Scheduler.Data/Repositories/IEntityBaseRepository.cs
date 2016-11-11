using Scheduler.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Scheduler.Data.Repositories
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        T GetSingle(Expression<Func<T, bool>> predicate);
        T GetSingleIncluding(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindIncluding(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        void Add(T entity);
        void Delete(T entity);
        void DeleteWhere(Expression<Func<T, bool>> predicate);
        void Edit(T entity);
        int Count();
    }
}
