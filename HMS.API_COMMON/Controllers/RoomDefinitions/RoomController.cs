using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_COMMON.Controllers.RoomDefinitions
{
    [ApiController]
    [Route("api/RoomDefinitions/[controller]")]
    public class RoomController :  BaseController<Room, RoomDTO>
    {
        public RoomController(IGenericCQRS<Room, RoomDTO> service) : base(service)
        {
        }
    }
}
