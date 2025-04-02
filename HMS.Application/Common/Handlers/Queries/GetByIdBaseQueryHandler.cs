using AutoMapper;
using HMS.Core;
using HMS.Core.Abstracts.Model;
using HMS.DataAccess.Common;
using HMS.Entities.Models.Base;
using MediatR;
using System.Linq.Expressions;

namespace HMS.Application.Common.Handlers.Queries
{
    public class GetByIdBaseQueryHandler<TRequest, TResponse, TEntityType, TReturnDtoType> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : class, new()
        where TReturnDtoType : class, new()
        where TEntityType : BaseModel, IBaseModel, new()
    {
        private readonly IUnitOfWork _work;


        public GetByIdBaseQueryHandler(IUnitOfWork work)
        {
            _work = work;
        }

        public virtual List<Expression<Func<TEntityType, object>>>? SetInclude()
        {
            return null;
        }

        public virtual bool SetTracking()
        {
            return false;
        }

        public virtual async Task<TResponse> HandleLoad(TRequest request, CancellationToken cancellationToken)
        {
            dynamic response;

            try
            {
                TEntityType dbData = new TEntityType();
                TReturnDtoType sData = new TReturnDtoType();
                var entityModelName = typeof(TEntityType).Name;

                dbData = await _work.Repository<TEntityType>().GetByIdAsync((request as dynamic).Id , SetInclude() , SetTracking());

                var configuration = MapperConfig<TEntityType, TReturnDtoType>();
                IMapper mapper = configuration.CreateMapper();
                sData = mapper.Map<TEntityType, TReturnDtoType>(dbData);
                response = ActionResponse<TReturnDtoType>.Ok(sData);
            }
            catch (Exception e)
            {
                response = ActionResponse<TReturnDtoType>.BadRequest("Get Error " + e?.Message);
            }

            return response;

        }

        public virtual MapperConfiguration MapperConfig<TSource, TDestination>()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap(typeof(TSource), typeof(TDestination));
            });
        }

        Task<TResponse> IRequestHandler<TRequest, TResponse>.Handle(TRequest request, CancellationToken cancellationToken)
        {
            return HandleLoad(request, cancellationToken);
        }
    }
}
