using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.FrontOffice.ReservationModels
{
    public class ReservationDaily : EnBaseModel
    {
        public ReservationDaily()
        {
            ReservastionDailyGuests = new List<ReservastionDailyGuest>();
            Child = 0;
            Free = 0;
            Beb = 0;
        }

        public DateTime Date { get; set; }
        public Guid? RoomId { get; set; }
        public int Pax { get; set; }
        public int Child { get; set; }
        public int Free { get; set; }
        public int Beb { get; set; }
        public Room Room { get; set; }
        public Guid ReservationDetailId { get; set; }
        public virtual ReservationDetail ReservationDetail { get; set; }
        public virtual ICollection<ReservastionDailyGuest> ReservastionDailyGuests { get; set; }

    }
}
