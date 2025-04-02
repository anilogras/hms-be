using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Dto.Base;
using HMS.DTO.DefinitionDTO.CRM.Health;
using HMS.DTO.MainDTOs.CRM;
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
    public class HospitalController : BaseController<Hospital, HospitalDTO>
    {
        public HospitalController(IGenericCQRS<Hospital, HospitalDTO> service) : base(service)
        {
        }
    }
}
