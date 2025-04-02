using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Core.Enums;
using HMS.Dto.Base;
using HMS.DTO.DefinitionDTO.CRM.Health;
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
    public class RoutineCheckupController : BaseController<RoutineCheckup, RoutineCheckupDTO>
    {
        public RoutineCheckupController(IGenericCQRS<RoutineCheckup, RoutineCheckupDTO> service) : base(service)
        {
        }
    }
}
