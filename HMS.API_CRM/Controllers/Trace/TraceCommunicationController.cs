using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.CRM.Trace;
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
    public class TraceCommunicationController : BaseController<TraceCommunication, TraceCommunicationDTO>
    {
        public TraceCommunicationController(IGenericCQRS<TraceCommunication, TraceCommunicationDTO> service) : base(service)
        {
        }
    }
}
