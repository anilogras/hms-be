using HMS.Application.Common.Handlers.Queries;
using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.DataAccess.Common;
using HMS.Dto.Base;
using HMS.Entities.Models.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Common.Queries
{
    public class GetByIdQuery<TEntity, TDto> : IRequest<ActionResponse<TDto>>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public Guid Id { get; }

        public GetByIdQuery(Guid id)
        {
            Id = id;
        }
    }


    public class GetByIdQueryHandler<TEntity, TDto> : GetByIdBaseQueryHandler<GetByIdQuery<TEntity, TDto>, ActionResponse<TDto>, TEntity, TDto>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public GetByIdQueryHandler(IUnitOfWork work) : base(work)
        {
        }
    }

}
