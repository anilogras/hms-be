using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Core.Enums;
using HMS.DTO.DefinitionDTO;
using HMS.DTO.DefinitionDTO.CRM.Trace;
using HMS.Entities.Models.MainModels.CRM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HMS.API_CRM.Controllers.Trace
{
    [ApiController]
    [Route("api/Trace/[controller]")]
    public class TraceRecordController : BaseController<TraceRecord, TraceRecordDTO>
    {
        public TraceRecordController(IGenericCQRS<TraceRecord, TraceRecordDTO> service) : base(service)
        {
        }
    }
}
