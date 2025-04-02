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
    public class DeleteCommand<TEntity , TDto> : IRequest<ActionResponse<TDto>>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public Guid Id { get; }

        public DeleteCommand(Guid id)
        {
            Id = id;
        }
    }


    public class DeleteCommandHandler<TEntity , TDto> : DeleteBaseCommandHandler<DeleteCommand<TEntity , TDto>, ActionResponse<TDto>, TEntity , TDto>
        where TDto : BaseDto, IBaseDto, new()
        where TEntity : BaseModel, IBaseModel, new()
    {
        public DeleteCommandHandler(IUnitOfWork uow) : base(uow)
        {
        }
    }





}
