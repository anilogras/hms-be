using HMS.Application.Commands.SalesAndMarketing.ContractCommands;
using HMS.Application.Common.Abstracts;
using HMS.Application.Common.Commands;
using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using HMS.DTO.MainDTOs.SalesAndMarketing;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Common.Conctrete
{
    public class ContractCQRS:  IContractMethods
    {
        private readonly IMediator _mediator;

        public ContractCQRS(IMediator mediator) 
        {
            _mediator = mediator;
        }

        public Task<ActionResponse<ContractDTO>> CreateCommandAsync(ContractDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResponse<ContractDTO>> CreateContractAsync(ContractDTO dto)
        {
            return await _mediator.Send(new CreateContract(dto));
        }

        public Task<ActionResponse<ContractDTO>> DeleteCommandAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResponse<List<ContractDTO>>> GetAllCommandAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResponse<ContractDTO>> GetByIdCommandAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResponse<ContractDTO>> UpdateCommandAsync(ContractDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
