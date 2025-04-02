using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_COMMON.Controllers.RoomDefinitions
{
    [ApiController]
    [Route("api/RoomDefinitions/[controller]")]
    public class RoomPropertiesController : BaseController<RoomProperties, RoomPropertiesDTO>
    {
        public RoomPropertiesController(IGenericCQRS<RoomProperties, RoomPropertiesDTO> service) : base(service)
        {
        }
    }
}
