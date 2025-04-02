using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Core;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using HMS.DTO.MainDTOs.SalesAndMarketing;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;

namespace HMS.Application.Common.Abstracts
{
    public interface IContractMethods :IGenericCQRS<Contract,ContractDTO>
    {
        Task<ActionResponse<ContractDTO>> CreateContractAsync(ContractDTO dto);
    }
}
