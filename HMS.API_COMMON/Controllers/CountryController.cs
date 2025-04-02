using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.Common.Contact;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_COMMON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : BaseController<Country, CountryDTO>
    {
        public CountryController(IGenericCQRS<Country, CountryDTO> service) : base(service)
        {
        }
    }
}
