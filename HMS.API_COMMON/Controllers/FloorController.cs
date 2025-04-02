using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_COMMON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FloorController : BaseController<Floor, FloorDTO>
    {
        public FloorController(IGenericCQRS<Floor, FloorDTO> service) : base(service)
        {
        }
    }
}
