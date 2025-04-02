
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.FrontOffice.ReservationModels
{
    public class ReservastionDailyGuestDTO : BaseDto
    {
        public ReservastionDailyGuestDTO()
        {

        }
        public Guid ReservationDetailId { get; set; }
        public virtual ReservationDailyDTO ReservationDaily { get; set; }
        public int GuestOrder { get; set; }

        public Guid GuestId { get; set; }
        public virtual GuestDTO Guest { get; set; }

    }
}
