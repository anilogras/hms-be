using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.SalesAndMarketing.OutOfDTOs;
using HMS.DTO.MainDTOs.SalesAndMarketing;
using HMS.Entities.Models.Definition.SalesAndMarketing.OutOfEntities;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_FRONTOFFICE.Controllers.SalesAndMarketing.PriceTypeControllers
{
    [ApiController]
    [Route("api/SalesAndMarketing/[controller]")]
    public class PriceTypeController : BaseController<PriceType, PriceTypeDTO>
    {
        public PriceTypeController(IGenericCQRS<PriceType, PriceTypeDTO> service) : base(service)
        {
        }
    }
}
