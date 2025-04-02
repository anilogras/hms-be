using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_COMMON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : BaseController<Department, DepartmentDTO>
    {
        public DepartmentController(IGenericCQRS<Department, DepartmentDTO> service) : base(service)
        {
        }

    }
}
