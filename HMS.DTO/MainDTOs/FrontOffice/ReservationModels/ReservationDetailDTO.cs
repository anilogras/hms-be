
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DTO.DefinitionDTO.FronOffice;

namespace HMS.DTO.MainDTOs.FrontOffice.ReservationModels
{
    public class ReservationDetailDTO : BaseDto
    {
        public ReservationDetailDTO()
        {
            ReservationDailies = new List<ReservationDailyDTO>();
            
        }

        public DateTime? CinDate { get; set; }
        public DateTime? CoutDate { get; set; }
        public int ReservationOrder { get; set; }
        public Guid RoomLocationId { get; set; }
        public Guid PriceLocationId { get; set; }
        public Guid ReservationRecordId { get; set; }
        public string Voucher { get; set; }
        public bool IsFixedPrice { get; set; }
        public bool IsFixedRate { get; set; }
        public double? FixedPrice { get; set; }
        public double? FixedRate { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid BoardingHouseId { get; set; }
        public Guid AgencyId { get; set; }
        public Guid MarketId { get; set; }
        public virtual AgencyDTO Agency { get; set; }
        public virtual MarketDTO Market { get; set; }
        public virtual BoardingHouseDTO BoardingHouse { get; set; }

        public virtual ReservationRecordDTO ReservationRecord { get; set; }
        public virtual CurrencyDTO Currency { get; set; }
        public virtual RoomLocationDTO RoomLocation { get; set; }
        public virtual PriceLocationDTO PriceLocation { get; set; }
        public virtual List<ReservationDailyDTO> ReservationDailies { get; set; }
    }
}
