using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Core;
using HMS.Core.Services;
using HMS.DTO.MainDTOs.FrontOffice.ReservationModels;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_FRONTOFFICE.Controllers.Reservation
{
    [ApiController]
    [Route("api/FrontOffice/[controller]")]
    public class ReservationController : BaseController<ReservationRecord, ReservationRecordDTO>
    {
        private readonly IReservationMethods _service;

        public ReservationController(IReservationMethods service) : base(service)
        {
            _service = service;

        }

        [HttpPost("CreateReservation")]
        public async Task<ActionResult<CreateReservationBaseDto>> CreateReservation(CreateReservationBaseDto dto)
        {
            ActionResponse<CreateReservationBaseDto> _serviceResult = await _service.CreateReservation(dto);
            return Ok(new ServiceResult<CreateReservationBaseDto> { Data = _serviceResult.Data, DataCount = 1, Status = true });
        }
    }
}
