using SampleArch.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SampleArch.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
       where T : BaseEntity
    {
        protected readonly IDbSet<T> _dbset;
        protected DbContext _entities;

        protected GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }

        public virtual T Add(T entity) => _dbset.Add(entity);

        public virtual T Delete(T entity) => _dbset.Remove(entity);

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate) => _dbset.Where(predicate).AsEnumerable();

        public virtual IEnumerable<T> GetAll() => _dbset.AsEnumerable<T>();

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}