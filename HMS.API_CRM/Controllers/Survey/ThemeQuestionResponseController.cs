using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.CRM.Survey;
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
    public class ThemeQuestionResponseController : BaseController<ThemeQuestionResponse, ThemeQuestionResponseDTO>
    {
        public ThemeQuestionResponseController(IGenericCQRS<ThemeQuestionResponse, ThemeQuestionResponseDTO> service) : base(service)
        {
        }
    }
}
