using HMS.Core.Abstracts.Model;
using HMS.Entities.Models.Base;
using System.Linq.Expressions;

namespace HMS.DataAccess.Common
{
    public interface IRepository<TEntity>
        where TEntity : EnBaseModel, IBaseModel, new()
    {
        Task<TEntity?> GetByIdAsync(Guid id, List<Expression<Func<TEntity, object>>>? includes = null, bool track = true);
        Task<List<TEntity>> GetAllAsync(List<Expression<Func<TEntity, object>>>? includes = null, bool track = true);
        Task<List<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression ,List<Expression<Func<TEntity, object>>>? includes = null, bool track = true);
        Task<TEntity> AddAsync(TEntity model);
        void Remove(TEntity model);
        void RemoveById(Guid id);
        void RemoveRange(IEnumerable<TEntity> models);
        TEntity Update(TEntity model);
        Task<IEnumerable<TEntity>> GetPagedResponseAsync(int pageNumber, int pageSize, List<Expression<Func<TEntity, object>>>? includes = null, bool track = true);
        Task<List<TEntity>> GetPredicateAndInclude(Expression<Func<TEntity, bool>> predicate, List<Expression<Func<TEntity, object>>>? includes = null , bool tracking = true);

    }

}
