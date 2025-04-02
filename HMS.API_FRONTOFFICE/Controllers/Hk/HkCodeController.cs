using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_FRONTOFFICE.Controllers.Hk
{
    [ApiController]
    [Route("api/Hk/[controller]")]
    public class HkCodeController : BaseController<HKCode, HKCodeDTO>
    {
        public HkCodeController(IGenericCQRS<HKCode, HKCodeDTO> service) : base(service)
        {
        }
    }
}
