using AutoMapper;
using HMS.Application.Common.Handlers.Commands;
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

namespace HMS.Application.Common.Commands
{
    public class UpdateCommand<TEntity , TDto> : IRequest<ActionResponse<TDto>>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public TDto Dto { get; }

        public UpdateCommand(TDto dto)
        {
            Dto = dto;
        }
    }

    public class UpdateCommanHandler<TEntity , TDto> : UpdateBaseCommandHandler<UpdateCommand<TEntity , TDto>, ActionResponse<TDto>, TEntity,TDto>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public UpdateCommanHandler(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
        }
    }

}
