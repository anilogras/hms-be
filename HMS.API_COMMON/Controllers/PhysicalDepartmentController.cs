using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Dto.Base;
using HMS.DTO.DefinitionDTO;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.API_COMMON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhysicalDepartmentController : BaseController<PhysicalDepartment, PhysicalDepartmentDTO>
    {
        public PhysicalDepartmentController(IGenericCQRS<PhysicalDepartment, PhysicalDepartmentDTO> service) : base(service)
        {
        }

    }
}
