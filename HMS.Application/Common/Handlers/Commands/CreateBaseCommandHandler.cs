using AutoMapper;
using HMS.Business.Common.GeneralOperations;
using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.DataAccess;
using HMS.DataAccess.Common;
using HMS.Dto.Base;
using HMS.DTO;
using HMS.Entities.Models.Base;

using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HMS.Application.Common.Handlers.Commands
{
    public class CreateBaseCommandHandler<TRequest, TResponse, TEntityType , TDtoType> : IRequestHandler<TRequest, TResponse>
      where TRequest : IRequest<TResponse>
      where TResponse : class, new()
      where TEntityType : BaseModel, IBaseModel, new()
      where TDtoType : BaseDto, IBaseDto, new()

    {
        public readonly IUnitOfWork _uow;

        public CreateBaseCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public virtual void AddValueSet(BaseModel dbData)
        {
            DefaultValueOperations operations = new DefaultValueOperations();
            operations.AddValueSet(dbData);
        }


        public virtual async Task<TResponse> HandleLoad(TRequest request, CancellationToken cancellationToken)
        {
            dynamic response;
            try
            {
                var configuration = MapperConfig<TDtoType, TEntityType>();
                IMapper mapper = configuration.CreateMapper();
                TEntityType dbData = new TEntityType();
                AddValueSet( dbData);
                mapper.Map((request as dynamic).Dto, dbData);

                await _uow.Repository<TEntityType>().AddAsync(dbData);

                int isSuccess = await _uow.SaveChangesAsync(cancellationToken);
                if (isSuccess > 0)
                {
                    response = ActionResponse<TDtoType>.Ok((request as dynamic).Dto);
                }
                else
                {
                    response = ActionResponse<TDtoType>.BadRequest("An error occurred, check the data");
                }

            }
            catch (Exception ex)
            {
                response = ActionResponse<TDtoType>.BadRequest("An error occurred, " + ex.Message);
            }

            return response;
        }

        public virtual MapperConfiguration MapperConfig<TSource, TDestination>()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TSource, TDestination>();
                cfg.CreateMap<DateTime, DateTime>().ConvertUsing((s, d) => {
                    return DateTime.SpecifyKind(s, DateTimeKind.Utc);
                });
            });
            return config;
            
        }

        Task<TResponse> IRequestHandler<TRequest, TResponse>.Handle(TRequest request, CancellationToken cancellationToken)
        {
            return HandleLoad(request, cancellationToken);
        }
    }
}
