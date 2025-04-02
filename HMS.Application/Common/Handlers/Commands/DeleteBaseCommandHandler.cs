using AutoMapper;
using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.DataAccess;
using HMS.DataAccess.Common;
using HMS.Dto.Base;
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
    public class DeleteBaseCommandHandler<TRequest, TResponse, TEntityType , TDtoType> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : class, new()
        where TEntityType : BaseModel, IBaseModel, new()
        where TDtoType : BaseDto, IBaseDto, new()
    {
        public readonly IUnitOfWork _uow;

        public DeleteBaseCommandHandler(
            IUnitOfWork uow)
        {
            _uow = uow;
        }



        public virtual async Task<TResponse> HandleLoad(TRequest request, CancellationToken cancellationToken)
        {
            //dynamic response = ActionResponse<TActionResponseType>.Ok(request);
            var entityModelName = typeof(TEntityType).Name;
            dynamic response;

            try
            {
                TEntityType dbData = await _uow.Repository<TEntityType>().GetByIdAsync((request as dynamic).Id);
                _uow.Repository<TEntityType>().RemoveById(dbData.Id);

                TDtoType dto = new TDtoType();

                var configuration = MapperConfig<TEntityType, TDtoType>();
                IMapper mapper = configuration.CreateMapper();
                mapper.Map(dbData, dto);

                int isSuccess = await _uow.SaveChangesAsync(cancellationToken);
                if (isSuccess > 0)
                {
                    response = ActionResponse<TDtoType>.Ok(dto);
                    response.IsSuccessful = true;
                }
                else
                {
                    response = ActionResponse<TDtoType>.BadRequest("An error occurred, check the data");
                    response.IsSuccessful = false;

                }
            }
            catch (Exception ex)
            {
                response = ActionResponse<TDtoType>.BadRequest(new List<string> { ex.Message });
                response.IsSuccessful = false;

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
