using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL.Entites.Entites;

namespace DAL.Entites.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate);

        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}
