using HMS.Business.Common;
using HMS.DTO.MainDTOs.SalesAndMarketing;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Services.SalesAndMarketingOperations
{
    public interface IContractServices : IGenericService<Contract>
    {
        Contract CreateContract(string name, string code);
        Contract AddAgencyContract(Contract contract, List<ContractAgency> contractAgencies);
        Contract AddPackets(Contract contract, List<Packets> contractPackets);
        Contract AddPeriods(Contract contract, List<ContractPeriod> contractPeriods);
    }
}
