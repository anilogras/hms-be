using HMS.Application.Common.Abstracts;
using HMS.Application.Common.Commands;
using HMS.Application.Common.Queries;
using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using HMS.Entities.Models.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Common.Conctrete
{
    public class GenericCQRS<TEntity , TDto> : IGenericCQRS<TEntity , TDto>
               where TDto : BaseDto, IBaseDto, new()
               where TEntity : BaseModel, IBaseModel, new()
    {
        private readonly IMediator _mediator;

        public GenericCQRS(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ActionResponse<TDto>> CreateCommandAsync(TDto dto)
        {
            return await _mediator.Send(new CreateCommand<TEntity , TDto>(dto));
        }

        public async Task<ActionResponse<TDto>> UpdateCommandAsync(TDto dto)
        {
            return await _mediator.Send(new UpdateCommand<TEntity , TDto>(dto));
        }

        public async Task<ActionResponse<TDto>> DeleteCommandAsync(Guid id)
        {
            return await _mediator.Send(new DeleteCommand<TEntity , TDto>(id));
        }

        public async Task<ActionResponse<TDto>> GetByIdCommandAsync(Guid id)
        {
            return await _mediator.Send(new GetByIdQuery<TEntity, TDto>(id));
        }

        public async Task<ActionResponse<List<TDto>>> GetAllCommandAsync()
        {
            return await _mediator.Send(new GetAllQueries<TEntity, TDto>());
        }

       
    }

}
