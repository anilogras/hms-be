using HMS.Business.Common;
using HMS.Business.Common.GeneralOperations;
using HMS.Business.Services.SalesAndMarketingOperations;
using HMS.DataAccess.Common;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;

namespace HMS.Business.Concrete.SalesAndMarketingOperations
{
    public class ContractServices : GenericService<Contract> , IContractServices  , IGenericService<Contract>
    {
        public ContractServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Contract CreateContract(string name , string code)
        {

            Contract contract = new Contract()
            {
                Deleted = false,
                Name = name,
                Code = code,
            };

            DefaultValueOperations operations = new DefaultValueOperations();
            operations.AddValueSet(contract);

            return contract;
        }

        public Contract AddAgencyContract(Contract contract, List<ContractAgency> contractAgencies)
        {
            DefaultValueOperations operations = new DefaultValueOperations();

            if (contractAgencies != null)
            {
                if (contract.Agencys == null)
                {
                    contract.Agencys = new List<ContractAgency>();
                }

                foreach (ContractAgency item in contractAgencies)
                {
                    operations.AddValueSet(item);
                    contract.Agencys.Add(item);
                }
            }
            return contract;
        }

        public Contract AddPeriods(Contract contract, List<ContractPeriod> contractPeriods)
        {
            DefaultValueOperations operations = new DefaultValueOperations();
            if (contractPeriods != null)
            {
                contract.Periods = new List<ContractPeriod>();

                foreach (ContractPeriod item in contractPeriods)
                {
                    operations.AddValueSet(item);
                    contract.Periods.Add(item);
                }
            }
            return contract;
        }

        public Contract AddPackets(Contract contract, List<Packets> contractPackets)
        {
            DefaultValueOperations operations = new DefaultValueOperations();
            if (contractPackets != null)
            {
                contract.Packets = new List<Packets>();

                foreach (Packets item in contractPackets)
                {

                    operations.AddValueSet(item);
                    contract.Packets.Add(item);
                }
            }
            return contract;
        }
    }
}
