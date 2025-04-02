using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.CRM.Health;
using HMS.DTO.DefinitionDTO.CRM.Survey;
using HMS.Entities.Models.Definition.Crm.Health;
using HMS.Entities.Models.Definition.Crm.Survey;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.API_CRM.Controllers.Survey
{
    [ApiController]
    [Route("api/Survey/[controller]")]
    public class AnswerOptionController : BaseController<AnswerOption, AnswerOptionDTO>
    {
        public AnswerOptionController(IGenericCQRS<AnswerOption, AnswerOptionDTO> service) : base(service)
        {
        }
    }
}
