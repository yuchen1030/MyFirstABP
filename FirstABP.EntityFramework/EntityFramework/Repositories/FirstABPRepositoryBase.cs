using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace FirstABP.EntityFramework.Repositories
{
    public abstract class FirstABPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<FirstABPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected FirstABPRepositoryBase(IDbContextProvider<FirstABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class FirstABPRepositoryBase<TEntity> : FirstABPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected FirstABPRepositoryBase(IDbContextProvider<FirstABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
