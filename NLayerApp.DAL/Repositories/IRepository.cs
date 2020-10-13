using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Query;

using NLayerApp.DAL.Model.Base;

namespace NLayerApp.DAL.Repositories
{
    public interface IRepository<TEntity, in TKey>
        where TEntity : class, IEntity<TKey>

    {
        ValueTask<TEntity> GetById(TKey key);

        Task<ReadOnlyCollection<TEntity>> Query(
            Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int pageIndex = 0, int pageSize = int.MaxValue);

        Task<int> Delete(TEntity entity);

        Task<int> Update(TEntity entity);
        
        Task<int> Insert(TEntity entity);

        Task<int> AddRange(IEnumerable<TEntity> entities);
        
        Task<int> UpdateRange(IEnumerable<TEntity> entities);

        Task<int> RemoveRange(IEnumerable<TEntity> entities);
    }
}