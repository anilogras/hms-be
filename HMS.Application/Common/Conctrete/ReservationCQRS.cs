using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Application.Commands.SalesAndMarketing.ContractCommands;
using HMS.Application.Commands.SalesAndMarketing.ReservationRecordCommands;
using HMS.Application.Common.Abstracts;
using HMS.Core;
using HMS.DTO.MainDTOs.FrontOffice.ReservationModels;
using MediatR;

namespace HMS.Application.Common.Conctrete
{
    public class ReservationCQRS : IReservationMethods
    {
        private readonly IMediator _mediator;

        public ReservationCQRS(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task<ActionResponse<ReservationRecordDTO>> CreateCommandAsync(ReservationRecordDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResponse<CreateReservationBaseDto>> CreateReservation(CreateReservationBaseDto dto)
        {
            return await _mediator.Send(new CreateReservationRecord(dto));
        }

        public Task<ActionResponse<ReservationRecordDTO>> DeleteCommandAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResponse<List<ReservationRecordDTO>>> GetAllCommandAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResponse<ReservationRecordDTO>> GetByIdCommandAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResponse<ReservationRecordDTO>> UpdateCommandAsync(ReservationRecordDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
