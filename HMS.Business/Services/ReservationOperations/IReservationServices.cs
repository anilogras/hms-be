using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Business.Common;
using HMS.DataAccess.Migrations;
using HMS.DTO;
using HMS.DTO.MainDTOs.FrontOffice.ReservationModels;
using HMS.Entities.Models.CommonModels;
using HMS.Entities.Models.MainModels.FrontOffice.FolioModels;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;

namespace HMS.Business.Services.ReservationOperations
{
    public interface IReservationServices :IGenericService<ReservationRecord>
    {
        ReservationRecord CreateReservationRecord(CreateUpdateReservationRecordDTO dto);
        List<ReservationDetail> CreateReservationDetail(List<CreateUpdateReservationDTO> dto);
        List<ReservationDaily> CreateReservationDaily (CreateReservationDaily dailys);
        void ConnectDailyGuest(List<ReservationDaily> dailys, List<GuestDTO> dto);
        void CreateFolio(List<ReservationDetail> details);
        void CreateFolioDetail(ReservationRecord Records);
       
    }
}
