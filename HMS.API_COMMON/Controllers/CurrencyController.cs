using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_COMMON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : BaseController<Currency, CurrencyDTO>
    {
        public CurrencyController(IGenericCQRS<Currency, CurrencyDTO> service) : base(service)
        {
        }

    }
}
