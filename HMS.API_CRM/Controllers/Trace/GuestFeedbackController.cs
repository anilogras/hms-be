using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.CRM.Survey;
using HMS.DTO.DefinitionDTO.CRM.Trace;
using HMS.Entities.Models.Definition.Crm.Survey;
using HMS.Entities.Models.Definition.Crm.Trace;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.API_CRM.Controllers.Trace
{
    [ApiController]
    [Route("api/Trace/[controller]")]
    public class GuestFeedbackController : BaseController<GuestFeedback, GuestFeedbackDTO>
    {
        public GuestFeedbackController(IGenericCQRS<GuestFeedback, GuestFeedbackDTO> service) : base(service)
        {
        }
    }
}
