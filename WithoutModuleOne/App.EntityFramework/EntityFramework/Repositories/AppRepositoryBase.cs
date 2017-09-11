using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace App.EntityFramework.Repositories
{
    public abstract class AppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AppRepositoryBase(IDbContextProvider<AppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AppRepositoryBase<TEntity> : AppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AppRepositoryBase(IDbContextProvider<AppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
