using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Dto.Base;
using HMS.DTO.DefinitionDTO.CRM.Health;
using HMS.Entities.Models.Definition.Crm.Health;
using Microsoft.AspNetCore.Mvc;


namespace HMS.API_CRM.Controllers.Health
{
    [ApiController]
    [Route("api/Healt/[controller]")]
    public class ProcedureTypeController : BaseController<ProcedureType, ProcedureTypeDTO>
    {
        public ProcedureTypeController(IGenericCQRS<ProcedureType, ProcedureTypeDTO> service) : base(service)
        {
        }
    }
}
