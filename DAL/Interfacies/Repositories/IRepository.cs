using DAL.Interfacies.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfacies.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> All();

        TEntity GetByPredicate(Expression<Func<TEntity, bool>> f);
        IEnumerable<TEntity> GetEntries(Expression<Func<TEntity, bool>> f);
        TEntity GetById(int key);

        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        
    }
}
