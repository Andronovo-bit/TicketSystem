using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using TicketSystem.Data.Context;
using TicketSystem.Helper;
using TicketSystem.Models.Domain.Base;

namespace TicketSystem.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly DbSet<TEntity> _dbSet;

        public Repository(TicketSystemDataContext context)
        {
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<TEntity> FindAsync(int id)
        {
            return await FirstOrDefaultAsync(k => k.Id == id)
                .ConfigureAwait(false);
        }
        public Task<TEntity> FirstOrDefaultAsync()
        {
            return FirstOrDefaultAsync();
        }

        public  Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter)
        {
            return  _dbSet
                .FirstOrDefaultAsync(filter);
        }

        public virtual TEntity Insert(TEntity entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;
            return _dbSet.Add(entity).Entity;
        }

        public virtual void InsertRange(params TEntity[] entities)
        {
            _dbSet.AddRange(entities);
        }

        public virtual TEntity Update(TEntity entity)
        {
            entity.UpdateDate = DateTime.Now;
            return _dbSet.Update(entity).Entity;
        }

        public virtual void UpdateRange(params TEntity[] entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public virtual void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void DeleteRange(params TEntity[] entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public virtual IQueryable<TEntity> Queryable(params string[] includeProperties)
        {
            return _dbSet
                .AsQueryable()
                .Including(includeProperties);
        }
    }
}