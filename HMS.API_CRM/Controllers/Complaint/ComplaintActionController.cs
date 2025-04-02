using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Core.Enums;
using HMS.Dto.Base;
using HMS.DTO.DefinitionDTO.CRM.Complaint;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.Crm.Complaint;
using HMS.Entities.Models.Definition.FrontOffice;
using HMS.Entities.Models.MainModels.CRM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.API_CRM.Controllers.Complaint
{
    [ApiController]
    [Route("api/Complaint/[controller]")]
    public class ComplaintActionController : BaseController<ComplaintAction, ComplaintActionDTO>
    {
        public ComplaintActionController(IGenericCQRS<ComplaintAction, ComplaintActionDTO> service) : base(service)
        {
        }
    }
}
