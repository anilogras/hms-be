using AutoMapper;
using HMS.Core;
using HMS.Core.Abstracts.Model;
using HMS.DataAccess.Common;
using HMS.Entities.Models.Base;

using MediatR;
using System.Linq.Expressions;

namespace HMS.Application.Common.Handlers.Commands
{
    public class GetBaseCommandHandler<TRequest, TResponse, TEntityType, TReturnDtoType> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : class, new()
        where TReturnDtoType : class, new()
        where TEntityType : BaseModel, IBaseModel, new()
    {
        private readonly IUnitOfWork _work;
        protected TRequest? _request;
        private Guid? PropGuid { get; set; }
        public bool stringInc { get; set; }

        public GetBaseCommandHandler(IUnitOfWork work)
        {
            _work = work;
        }

        public virtual Expression<Func<TEntityType, bool>>? SetPredicate()
        {
            return x => x.Deleted == false;
        }

        public virtual Func<IQueryable<TEntityType>, IOrderedQueryable<TEntityType>>? SetOrder()
        {
            return x => x.OrderBy(xc => xc.Id);
        }

        public virtual List<Expression<Func<TEntityType, object>>>? SetInclude()
        {
            return null;
        }

        public virtual bool SetTracking()
        {
            return true;
        }
        public virtual List<string>? SetStringInclude()
        {
            return null;
        }

        public virtual async Task<TResponse> HandleLoad(TRequest request, CancellationToken cancellationToken)
        {
            _request = request;
            dynamic response;

            try
            {
                IEnumerable<TEntityType> dbData = new List<TEntityType>();
                IEnumerable<TReturnDtoType> sData = new List<TReturnDtoType>();
                var entityModelName = typeof(TEntityType).Name;

                dbData = await _work.Repository<TEntityType>().FindByConditionAsync(SetPredicate());



                var configuration = MapperConfig<TEntityType, TReturnDtoType>();
                IMapper mapper = configuration.CreateMapper();

                sData = mapper.Map<IEnumerable<TEntityType>, IEnumerable<TReturnDtoType>>(dbData);

                response = ActionResponse<List<TReturnDtoType>>.Ok(sData.ToList());
            }
            catch (Exception e)
            {
                response = ActionResponse<List<TReturnDtoType>>.BadRequest("Get Error" + e.Message);
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
