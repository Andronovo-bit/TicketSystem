using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> FindAsync(int id);

        Task<TEntity> FirstOrDefaultAsync();

        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter);

        TEntity Insert(TEntity entity);

        void InsertRange(params TEntity[] entities);

        TEntity Update(TEntity entity);

        void UpdateRange(params TEntity[] entities);

        void Delete(int id);

        void Delete(TEntity entity);

        void DeleteRange(params TEntity[] entities);

        IQueryable<TEntity> Queryable(params string[] includeProperties);
    }