using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

using NLayerApp.DAL.Model.Base;

namespace NLayerApp.DAL.Repositories.Data
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>

    {
        private ShopDbContext _context;

        public Repository(ShopDbContext context)
        {
            _context = context;
        }

        public ValueTask<TEntity> GetById(TKey key)
        {
            return _context.FindAsync<TEntity>(key);
        }

        public Task<ReadOnlyCollection<TEntity>> Query(
            Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = _context.Set<TEntity>().AsNoTracking();

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            query = query
                .Skip(pageIndex * pageSize)
                .Take(pageSize);

            return Task.FromResult(new ReadOnlyCollection<TEntity>(query.ToList()));
        }

        public async Task<int> Delete(TEntity entity)
        {
            _context.Remove(entity);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(TEntity entity)
        {
            _context.Update(entity);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Insert(TEntity entity)
        {
            _context.Add(entity);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddRange(IEnumerable<TEntity> entities)
        {
            _context.AddRange(entities);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateRange(IEnumerable<TEntity> entities)
        {
            _context.UpdateRange(entities);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.RemoveRange(entities);

            return await _context.SaveChangesAsync();
        }
    }
}