using HMS.Core.Services;
using Microsoft.AspNetCore.Mvc;
using HMS.Application.Common.Abstracts;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Entities.Models.Base;
using HMS.Dto.Base;
using HMS.Core;

namespace HMS.API_COMMON.Controllers.Common
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TEntity, TDto> : ControllerBase
               where TEntity : BaseModel, IBaseModel, new()
               where TDto : BaseDto, IBaseDto, new()
    {
        private readonly IGenericCQRS<TEntity, TDto> _service;

        public BaseController(IGenericCQRS<TEntity, TDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<ActionResult<List<TDto>>> GetAll()
        {
            ActionResponse<List<TDto>> _serviceResult = await _service.GetAllCommandAsync();
            return Ok(new ServiceResult<List<TDto>> { Data = _serviceResult.Data, DataCount = _serviceResult.Data.Count(), Status = true });
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TDto>> GetById(Guid id)
        {
            ActionResponse<TDto> _serviceResult = await _service.GetByIdCommandAsync(id);

            if (_serviceResult == null)
                return NotFound(new ServiceResult<TDto> { Data = _serviceResult.Data, DataCount = 0, Status = false });

            return Ok(new ServiceResult<TDto> { Data = _serviceResult.Data, DataCount = _serviceResult.Data != null ? 1 : 0, Status = true });
        }

        [HttpPost]
        public virtual async Task<ActionResult<TDto>> Post(TDto dto)
        {
            ActionResponse<TDto> _serviceResult = await _service.CreateCommandAsync(dto);
            return Ok(new ServiceResult<TDto> { Data = _serviceResult.Data, DataCount = 1, Status = true });
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Put(Guid id, TDto dto)
        {
            if (id != dto.Id)
            {
                List<ServiceResultError> err = new List<ServiceResultError>();
                err.Add(new ServiceResultError("Id bilgisi bulunamdı."));
                return BadRequest(new ServiceResult<TDto> { Data = dto, DataCount = 1, Status = false, Errors = err });
            }

            ActionResponse<TDto> _serviceResult = await _service.UpdateCommandAsync(dto);
            return Ok(new ServiceResult<TDto> { Data = _serviceResult.Data, DataCount = 1, Status = true });
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(Guid id)
        {
            ActionResponse<TDto>  result = await _service.DeleteCommandAsync(id);
            if (result.IsSuccessful)
            {
                return Ok(new ServiceResult<TDto> { Data = result.Data, DataCount = 1, Status = true });

            }
            else
            {
                return BadRequest(new ServiceResult<TDto> { Data = result.Data, DataCount = 1, Status = false });
            }
        }
    }
}
