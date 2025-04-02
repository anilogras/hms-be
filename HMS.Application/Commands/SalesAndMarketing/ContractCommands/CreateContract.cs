using AutoMapper;
using HMS.Application.Common.Handlers.Commands;
using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Core;
using HMS.DataAccess.Common;
using HMS.Dto.Base;
using HMS.Entities.Models.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;
using HMS.DTO.MainDTOs.SalesAndMarketing;
using System.Xml.Linq;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using HMS.Business.Services.SalesAndMarketingOperations;
using HMS.Business.Common.GeneralOperations;

namespace HMS.Application.Commands.SalesAndMarketing.ContractCommands
{
    public class CreateContract : IRequest<ActionResponse<ContractDTO>>
    {
        public ContractDTO Dto { get; }

        public CreateContract(ContractDTO dto)
        {
            Dto = dto;
        }
    }



    public class CreateContractHandler : CreateBaseCommandHandler<CreateContract, ActionResponse<ContractDTO>, Contract, ContractDTO>
    {
        private readonly IContractServices _contractServices;
        private readonly IMapper _mapper;

        public CreateContractHandler(IUnitOfWork uow, IContractServices contractServices) : base(uow)
        {
            _contractServices = contractServices;

            var config = new MapperConfiguration(cfg =>
            {
                // Ana model eşlemesi
                cfg.CreateMap<ContractDTO, Contract>();

                // Alt nesneler için eşlemeler
                cfg.CreateMap<ContractPeriodDTO, ContractPeriod>();
                cfg.CreateMap<ContractAgencyDTO, ContractAgency>();
                cfg.CreateMap<PacketsDTO, Packets>();
                cfg.CreateMap<ConditionDTO, Condition>();
                //cfg.CreateMap<DateTime, DateTime>().ConvertUsing((s, d) =>
                //{
                //    return DateTime.SpecifyKind(s, DateTimeKind.Utc);
                //});

            });

            _mapper = config.CreateMapper();
        }

        public override async Task<ActionResponse<ContractDTO>> HandleLoad(CreateContract request, CancellationToken cancellationToken)
        {
            var _tempContractMap = _mapper.Map<Contract>(request.Dto);
            DefaultValueOperations operations = new DefaultValueOperations();
            operations.AddValueSet(_tempContractMap);
            operations.AddValueSet(_tempContractMap.Condition);
            foreach (var item in _tempContractMap.Periods)
            {
                operations.AddValueSet(item);

            }
            foreach (var item in _tempContractMap.Agencys)
            {
                operations.AddValueSet(item);

            }
            foreach (var item in _tempContractMap.Packets)
            {
                operations.AddValueSet(item);
                operations.AddValueSet(item.Condition);


            }
            operations.AddValueSet(_tempContractMap.Condition);
            await _uow.Repository<Contract>().AddAsync(_tempContractMap);
            dynamic response;
            var result = await _uow.SaveChangesAsync();
            if (result > 0)
            {
                response = ActionResponse<ContractDTO>.Ok((request as dynamic).Dto);
            }
            else
            {
                response = ActionResponse<ContractDTO>.BadRequest("An error occurred, check the data");
            }
            return response;
        }
    }

}
