using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.FrontOffice.ReservationModels
{
    public class CreateUpdateReservationDTO 
    {
       
        public DateTime? CinDate { get; set; }
        public DateTime? CoutDate { get; set; }
        public Guid RoomLocationId { get; set; }
        public Guid PriceLocationId { get; set; }
        public string Voucher { get; set; }
        public bool IsFixedPrice { get; set; }
        public bool IsFixedRate { get; set; }
        public double? FixedPrice { get; set; }
        public double? FixedRate { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid BoardingHouseId { get; set; }
        public Guid AgencyId { get; set; }
        public Guid MarketId { get; set; }
        public List<GuestDTO>? Guests { get; set; }
        public CreateReservationDaily daily { get; set; }

    }
}
