using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.CRM.Survey;
using HMS.DTO.MainDTOs.CRM;
using HMS.Entities.Models.MainModels.CRM;
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
    public class SurveyRecordController : BaseController<SurveyRecord, SurveyRecordDTO>
    {
        public SurveyRecordController(IGenericCQRS<SurveyRecord, SurveyRecordDTO> service) : base(service)
        {
        }
    }

}
