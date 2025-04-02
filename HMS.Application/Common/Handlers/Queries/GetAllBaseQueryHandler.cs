using AutoMapper;
using HMS.Core.Abstracts.Model;
using HMS.Core;
using HMS.DataAccess.Common;
using HMS.Entities.Models.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HMS.Dto.Base;
using HMS.Core.Abstracts.Dto;
using System.Xml.Linq;

namespace HMS.Application.Common.Handlers.Queries
{
    public class GetAllBaseQueryHandler<TRequest, TResponse, TEntityType, TReturnDtoType> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : class, new()
        where TReturnDtoType : BaseDto, IBaseDto, new()
        where TEntityType : BaseModel, IBaseModel, new()
    {
        private readonly IUnitOfWork _work;

        public GetAllBaseQueryHandler(IUnitOfWork work)
        {
            _work = work;
        }

        public virtual Expression<Func<TEntityType, bool>>? SetPredicate()
        {
            return x => x.Deleted == false;
        }

        public virtual Func<TEntityType, IComparable>? SetOrder()
        {
            return x => x.Id;
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
                List<TEntityType> dbData = new List<TEntityType>();
                List<TReturnDtoType> sData = new List<TReturnDtoType>();
                var entityModelName = typeof(TEntityType).Name;

                dbData = await _work.Repository<TEntityType>().GetPredicateAndInclude(SetPredicate(), SetInclude() , SetTracking());
                dbData = dbData.OrderBy(SetOrder()).ToList();

                var configuration = MapperConfig<TEntityType, TReturnDtoType>();
                IMapper mapper = configuration.CreateMapper();
                sData = mapper.Map<List<TEntityType>, List<TReturnDtoType>>(dbData);
                response = ActionResponse<List<TReturnDtoType>>.Ok(sData);
            }
            catch (Exception e)
            {
                response = ActionResponse<TReturnDtoType>.BadRequest("Get Error " + e.Message);
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
