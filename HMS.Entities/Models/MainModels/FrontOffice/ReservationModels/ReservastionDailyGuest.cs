using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.FrontOffice.ReservationModels
{
    public class ReservastionDailyGuest : EnBaseModel
    {
        public ReservastionDailyGuest()
        {

        }

        public Guid ReservationDetailId { get; set; }
        public virtual ReservationDaily ReservationDaily { get; set; }
        public int GuestOrder { get; set; }

        public Guid GuestId { get; set; }
        public virtual Guest Guest { get; set; }

    }
}
