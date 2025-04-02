using AutoMapper;
using HMS.Application.Common.Handlers.Commands;
using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DataAccess.Common;

namespace  HMS.Application.Common.Commands
{
    public class CreateCommand<TEntity , TDto> : IRequest<ActionResponse<TDto>>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public TDto Dto { get; }

        public CreateCommand(TDto dto)
        {
            Dto = dto;
        }
    }

    public class CreateCommandHandler<TEntity , TDto> : CreateBaseCommandHandler<CreateCommand<TEntity , TDto>, ActionResponse<TDto>, TEntity , TDto>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public CreateCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
        }
    }

}
