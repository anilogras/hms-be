using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Dto.Base;
using HMS.DTO.DefinitionDTO.CRM.Complaint;
using HMS.DTO.DefinitionDTO.CRM.Health;
using HMS.Entities.Models.Definition.Crm.Complaint;
using HMS.Entities.Models.Definition.Crm.Health;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.API_CRM.Controllers.Health
{
    [ApiController]
    [Route("api/Healt/[controller]")]
    public class DailyProcedureController : BaseController<DailyProcedure, DailyProcedureDTO>
    {
        public DailyProcedureController(IGenericCQRS<DailyProcedure, DailyProcedureDTO> service) : base(service)
        {
        }
    }
}
