using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Common.Abstracts
{
    public interface IGenericCQRS<TEntity, TDto>
               where TDto : BaseDto, IBaseDto, new()
               where TEntity : BaseModel, IBaseModel, new()
    {
        Task<ActionResponse<TDto>> CreateCommandAsync(TDto dto);
        Task<ActionResponse<List<TDto>>> GetAllCommandAsync();
        Task<ActionResponse<TDto>> GetByIdCommandAsync(Guid id);
        Task<ActionResponse<TDto>> UpdateCommandAsync(TDto dto);
        Task<ActionResponse<TDto>> DeleteCommandAsync(Guid id);
    }

}
