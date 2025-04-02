using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_FRONTOFFICE.Controllers.Reservation
{
    [ApiController]
    [Route("api/Reservation/[controller]")]
    public class ReservationPropertiesController : BaseController<ReservationProperties, ReservationPropertiesDTO>
    {
        public ReservationPropertiesController(IGenericCQRS<ReservationProperties, ReservationPropertiesDTO> service) : base(service)
        {
        }
    }
}
