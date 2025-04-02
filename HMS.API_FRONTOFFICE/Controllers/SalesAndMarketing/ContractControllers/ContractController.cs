using Autofac.Core;
using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.Core.Services;
using HMS.Core;
using HMS.DTO.DefinitionDTO.SalesAndMarketing.OutOfDTOs;
using HMS.DTO.MainDTOs.SalesAndMarketing;
using HMS.Entities.Models.Definition.SalesAndMarketing.OutOfEntities;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_FRONTOFFICE.Controllers.SalesAndMarketing.ContractControllers
{
    [ApiController]
    [Route("api/SalesAndMarketing/[controller]")]
    public class ContractController : BaseController<Contract, ContractDTO>
    {
        private readonly IContractMethods _service;

        public ContractController(IContractMethods service) : base(service)
        {
            _service = service;

        }

        [HttpPost]
        public override async Task<ActionResult<ContractDTO>> Post(ContractDTO dto)
        {
            ActionResponse<ContractDTO> _serviceResult = await _service.CreateContractAsync(dto);
            return Ok(new ServiceResult<ContractDTO> { Data = _serviceResult.Data, DataCount = 1, Status = true });
        }
    }
}
