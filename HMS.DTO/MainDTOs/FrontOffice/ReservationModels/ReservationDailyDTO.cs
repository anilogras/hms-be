
using HMS.DTO.DefinitionDTO.FronOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.FrontOffice.ReservationModels
{
    public class ReservationDailyDTO : BaseDto
    {
        public ReservationDailyDTO()
        {
            ReservastionDailyGuests = new List<ReservastionDailyGuestDTO>();
        }

        public DateTime Date { get; set; }
        public Guid RoomId { get; set; }
        public RoomDTO Room { get; set; }
        public Guid ReservationDetailId { get; set; }
        public int Pax { get; set; }
        public int Child { get; set; }
        public int Free { get; set; }
        public int Beb { get; set; }
        public virtual ReservationDetailDTO ReservationDetail { get; set; }
        public virtual ICollection<ReservastionDailyGuestDTO> ReservastionDailyGuests { get; set; }

    }
}
