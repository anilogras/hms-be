using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using HMS.Entities.Models.MainModels.FrontOffice.FolioModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.FrontOffice.ReservationModels
{
    public class ReservationDetail : EnBaseModel
    {
        public ReservationDetail()
        {
            ReservationDailies = new List<ReservationDaily>();
          
            IsFixedPrice = false; 
            IsFixedRate = false;
        }

        [Column(TypeName = "date")]
        public DateTime? CinDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CoutDate { get; set; }
        public string ReservationNo { get; set; }
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
        public virtual Agency Agency { get; set; }
        public virtual Market Market { get; set; }
        public virtual BoardingHouse BoardingHouse { get; set; }
        public virtual ReservationRecord ReservationRecord { get; set; }
        public virtual Currency Currency{ get; set; }
        public virtual RoomLocation RoomLocation{ get; set; }
        public virtual PriceLocation PriceLocation{ get; set; }
        public virtual List<ReservationDaily> ReservationDailies { get; set; }
        public virtual List<Folio> Folios { get; set; }

    }
}
