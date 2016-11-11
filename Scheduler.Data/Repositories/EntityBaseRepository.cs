using Scheduler.Data.Infrastructure;
using Scheduler.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace Scheduler.Data.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
             where T : class, IEntityBase, new()
    {
        private SchedulerDbContext _dataContext;

        #region Properties
        protected IDbFactory DbFactory
        {
            get;
        }

        protected SchedulerDbContext DbContext => _dataContext ?? (_dataContext = DbFactory.Init());

        public EntityBaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }
        #endregion

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return GetAll().FirstOrDefault(predicate);
        }

        public T GetSingleIncluding(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).FirstOrDefault(predicate);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IQueryable<T> FindIncluding(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return DbContext.Set<T>();
        }

        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = GetAll();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public void Add(T entity)
        {
            DbContext.Entry(entity);
            DbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            foreach (var entity in Find(predicate))
            {
                DbContext.Entry(entity).State = EntityState.Deleted;
            }
        }

        public void Edit(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            dbEntityEntry.State = EntityState.Modified;
        }

        public int Count()
        {
            return GetAll().Count();
        }
    }
}
