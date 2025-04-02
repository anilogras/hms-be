using AutoMapper;
using HMS.Core.Abstracts.Model;
using HMS.DataAccess.Common;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Common
{
    public class GenericService<TEntity> : IGenericService<TEntity>
      where TEntity : EnBaseModel, IBaseModel, new()
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenericService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TEntity?> GetByIdAsync(Guid id , List<Expression<Func<TEntity, object>>>? includes = null, bool track = true)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            return await repository.GetByIdAsync(id , includes , track);
        }

        public async Task<List<TEntity>> GetAllAsync(List<Expression<Func<TEntity, object>>>? includes = null, bool track = true)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            return await repository.GetAllAsync(includes , track);
        }

        public async Task<List<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression, List<Expression<Func<TEntity, object>>>? includes = null, bool track = true)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            return await repository.FindByConditionAsync(expression , includes , track);
        }

        public async Task<TEntity> AddAsync(TEntity model)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            return await repository.AddAsync(model);
        }

        public TEntity Update(TEntity model)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            return repository.Update(model);
        }

        public void RemoveById(Guid id)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            repository.RemoveById(id);
        }

        public void Remove(TEntity model)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            repository.Remove(model);
        }

        public void RemoveRange(IEnumerable<TEntity> models)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            repository.RemoveRange(models);
        }

        public async Task<IEnumerable<TEntity>> GetPagedResponseAsync(int pageNumber, int pageSize, List<Expression<Func<TEntity, object>>>? includes = null, bool track = true)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            return await repository.GetPagedResponseAsync(pageNumber, pageSize , includes , track);
        }

        public async Task<List<TEntity>> GetPredicateAndInclude(Expression<Func<TEntity, bool>> predicate, List<Expression<Func<TEntity, object>>> includes, bool track = true)
        {
            var repository = _unitOfWork.Repository<TEntity>();
            return await repository.GetPredicateAndInclude(predicate: predicate, includes: includes, track);
        }


    }


}
