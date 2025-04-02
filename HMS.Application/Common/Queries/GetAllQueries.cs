using HMS.Application.Common.Handlers.Queries;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Core;
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
    public class GetAllQueries<TEntity, TDto> : IRequest<ActionResponse<List<TDto>>>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
    }


    public class GetAllQueriesHandler<TEntity, TDto> : GetAllBaseQueryHandler<GetAllQueries<TEntity, TDto>, ActionResponse<List<TDto>>, TEntity, TDto>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public GetAllQueriesHandler(IUnitOfWork work) : base(work)
        {
        }
    }

}
