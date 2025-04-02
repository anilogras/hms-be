using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Application.Commands.SalesAndMarketing.ReservationRecordCommands;
using HMS.Core;
using HMS.DTO.MainDTOs.FrontOffice.ReservationModels;
using HMS.DTO.MainDTOs.SalesAndMarketing;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;

namespace HMS.Application.Common.Abstracts
{
  
    public interface IReservationMethods : IGenericCQRS<ReservationRecord, ReservationRecordDTO>
    {
        Task<ActionResponse<CreateReservationBaseDto>> CreateReservation(CreateReservationBaseDto dto);
    }
}
