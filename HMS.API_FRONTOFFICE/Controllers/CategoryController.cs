using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_FRONTOFFICE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : BaseController<Category, CategoryDTO>
    {
        public CategoryController(IGenericCQRS<Category, CategoryDTO> service) : base(service)
        {
        }
    }
}
