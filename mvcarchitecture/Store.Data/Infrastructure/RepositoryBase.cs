using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Store.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private StoreEntities dataContext;
        private readonly IDbSet<T> dbSet;

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        protected StoreEntities DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            var objects = dbSet.Where(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
    }
}