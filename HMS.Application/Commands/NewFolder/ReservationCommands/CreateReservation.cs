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
using HMS.DTO.MainDTOs.SalesAndMarketing;
using System.Xml.Linq;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using HMS.Business.Services.SalesAndMarketingOperations;
using HMS.Business.Common.GeneralOperations;
using HMS.DTO.MainDTOs.FrontOffice.ReservationModels;
using HMS.Business.Services.ReservationOperations;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;

namespace HMS.Application.Commands.SalesAndMarketing.ReservationRecordCommands
{
    public class CreateReservationRecord : IRequest<ActionResponse<CreateReservationBaseDto>>
    {
        public CreateReservationBaseDto dto { get; }

        public CreateReservationRecord(CreateReservationBaseDto dto)
        {
            this.dto = dto;

        }
    }



    public class CreateReservationRecordHandler : CreateBaseCommandHandler<CreateReservationRecord, ActionResponse<CreateReservationBaseDto>, ReservationRecord, ReservationRecordDTO>
    {
        private readonly IReservationServices _ReservationRecordServices;
        private readonly IMapper _mapper;

        public CreateReservationRecordHandler(IUnitOfWork uow, IReservationServices ReservationRecordServices) : base(uow)
        {
            _ReservationRecordServices = ReservationRecordServices;
            var config = new MapperConfiguration(cfg =>
            {
              
                cfg.CreateMap<DateTime, DateTime>().ConvertUsing((s, d) =>
                {
                    return DateTime.SpecifyKind(s, DateTimeKind.Unspecified);
                });

            });

            _mapper = config.CreateMapper();
        }

        public override async Task<ActionResponse<CreateReservationBaseDto>> HandleLoad(CreateReservationRecord request, CancellationToken cancellationToken)
        {
            ReservationRecord newRes = _ReservationRecordServices.CreateReservationRecord(request.dto.record);
            newRes.ReservationDetails = _ReservationRecordServices.CreateReservationDetail(request.dto.details);
            _ReservationRecordServices.CreateFolio(newRes.ReservationDetails.ToList());
            _ReservationRecordServices.CreateFolioDetail(newRes);
            var _tempContractMap = _mapper.Map<ReservationRecord>(newRes);

            await _uow.Repository<ReservationRecord>().AddAsync(_tempContractMap);
            dynamic response;
            var result = await _uow.SaveChangesAsync();
            if (result > 0)
            {
                response = ActionResponse<CreateReservationBaseDto>.Ok((request as dynamic).dto);
            }
            else
            {
                response = ActionResponse<CreateReservationBaseDto>.BadRequest("An error occurred, check the data");
            }
            return response;
        }
    }

}
