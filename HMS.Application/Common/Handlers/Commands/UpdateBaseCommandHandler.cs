using AutoMapper;
using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.DataAccess.Common;
using HMS.Dto.Base;
using HMS.Entities.Models.Base;
using MediatR;
using System.Linq.Expressions;

namespace HMS.Application.Common.Handlers.Commands
{
    /// <summary>
    /// Generic UpdateCommandHandler
    /// </summary>
    /// <typeparam name="TRequest">IRequestHandler TRequest Type</typeparam>
    /// <typeparam name="TResponse">IRequestHandler TResponse Type</typeparam>
    /// <typeparam name="TEntityType">Repository Model</typeparam>
    public class UpdateBaseCommandHandler<TRequest, TResponse, TEntityType, TDtoType> : IRequestHandler<TRequest, TResponse>
            where TRequest : IRequest<TResponse>
            where TResponse : class, new()
            where TEntityType : BaseModel, IBaseModel, new()
            where TDtoType : BaseDto, IBaseDto, new()

    {
        public readonly IUnitOfWork _uow;

        public UpdateBaseCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public virtual Expression<Func<TEntityType, bool>>? SetPredicate(Guid id)
        {
            return x => (x as BaseModel).Id == id;
        }

        public virtual Func<IQueryable<TEntityType>, IOrderedQueryable<TEntityType>>? SetOrder()
        {
            return null;
        }

        public virtual List<Expression<Func<TEntityType, object>>>? SetInclude()
        {
            return null;
        }

        public virtual bool SetTracking()
        {
            return true;
        }

        public virtual async Task<TResponse> HandleLoad(TRequest request, CancellationToken cancellationToken)
        {
            dynamic response;
            var entityModelName = typeof(TEntityType).Name;

            try
            {

                var configuration = MapperConfig<TDtoType, TEntityType>();
                IMapper mapper = configuration.CreateMapper();

                TEntityType dbData = new TEntityType();

                var configurationResponse = MapperConfig<TEntityType, TDtoType>();
                IMapper mapperResponse = configurationResponse.CreateMapper();

                TDtoType responseData = new TDtoType();

                dbData = await _uow.Repository<TEntityType>().GetByIdAsync((request as dynamic).Dto.Id);

                if (dbData != null)
                {
                    mapper.Map<TDtoType, TEntityType>((request as dynamic).Dto, dbData);
                    _uow.Repository<TEntityType>().Update(dbData);

                }
                else
                {
                    response = ActionResponse<TDtoType>.BadRequest("Cannot find entity");
                    return response;
                }

                mapper.Map((request as dynamic).Dto, dbData);

                int isSuccess = await _uow.SaveChangesAsync(cancellationToken);

                if (isSuccess > 0)
                {
                    mapperResponse.Map<TEntityType, TDtoType>(dbData, responseData);
                    response = ActionResponse<TDtoType>.Ok(responseData);
                }
                else
                {
                    response = ActionResponse<TDtoType>.BadRequest("An error occurred, check the data");

                }
            }
            catch (Exception ex)
            {
                response = ActionResponse<TDtoType>.BadRequest($"{entityModelName} not modified: " + ex.Message);
            }

            return response;
        }

        public virtual MapperConfiguration MapperConfig<TSource, TDestination>()
        {
            return new MapperConfiguration(cfg => cfg.CreateMap(typeof(TSource), typeof(TDestination)));
        }

        Task<TResponse> IRequestHandler<TRequest, TResponse>.Handle(TRequest request, CancellationToken cancellationToken)
        {
            return HandleLoad(request, cancellationToken);
        }
    }
}
