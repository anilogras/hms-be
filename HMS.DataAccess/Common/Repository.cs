using HMS.Core.Abstracts.Model;
using HMS.DataAccess.Context;
using HMS.Entities.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HMS.DataAccess.Common
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : EnBaseModel, IBaseModel, new()
    {
        private readonly HMSContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(HMSContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id, List<Expression<Func<TEntity, object>>>? includes = null, bool track = true)
        {
            IQueryable<TEntity> query = track ? 
                _dbSet : 
                _dbSet.AsNoTracking();

            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            return await query.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(List<Expression<Func<TEntity, object>>>? includes = null, bool track = true)
        {
            IQueryable<TEntity> query = track ? 
                _dbSet : 
                _dbSet.AsNoTracking();

            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            return await query.ToListAsync();
        }

        public async Task<List<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression , List<Expression<Func<TEntity, object>>>? includes = null, bool track = true)
        {
            IQueryable<TEntity> query = track ? 
                _dbSet : 
                _dbSet.AsNoTracking();

            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            return await query.Where(expression).ToListAsync();
        }

        public async Task<TEntity> AddAsync(TEntity model)
        {
            await _dbSet.AddAsync(model);
            return model;
        }

        public void Remove(TEntity model)
        {
            model.Deleted = true;
            _dbSet.Update(model);
        }

        public void RemoveById(Guid id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                entity.Deleted = true;
                _dbSet.Update(entity);
            }
        }

        public void RemoveRange(IEnumerable<TEntity> models)
        {
            foreach (var model in models)
            {
                model.Deleted = true;
            }
            _dbSet.UpdateRange(models);
        }

        public TEntity Update(TEntity model)
        {
            _dbSet.Update(model);
            return model;
        }

        public async Task<IEnumerable<TEntity>> GetPagedResponseAsync(int pageNumber, int pageSize ,  List<Expression<Func<TEntity, object>>>? includes = null , bool track = true)
        {
            IQueryable<TEntity> query = track ? 
                _dbSet.Skip(pageNumber * pageSize).Take(pageSize) : 
                _dbSet.Skip(pageNumber * pageSize).Take(pageSize).AsNoTracking();

            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            return await query.ToListAsync();
        }

        public async Task<List<TEntity>> GetPredicateAndInclude(Expression<Func<TEntity, bool>> predicate, List<Expression<Func<TEntity, object>>>? includes = null, bool track = true)
        {

            IQueryable<TEntity> query = track ?
                _dbSet : 
                _dbSet.AsNoTracking();

            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            return await query.Where(predicate).ToListAsync();
        }
    }
}
