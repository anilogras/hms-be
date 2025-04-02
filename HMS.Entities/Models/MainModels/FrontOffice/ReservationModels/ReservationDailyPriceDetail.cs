using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;

namespace HMS.Entities.Models.MainModels.FrontOffice.ReservationModels
{
    public class ReservationDailyPriceDetail : EnBaseModel
    {
        public double Amount { get; set; }
        public Guid ReservationDailyId { get; set; }
        public virtual ReservationDaily ReservationDaily{ get; set; }
        public Guid? PeriodPricesId { get; set; } // Ham Fiyat satırında sadece dolu olacak
        public virtual PeriodPrices PeriodPrices { get; set; }
        public Guid? PacketsId { get; set; } //İNDİRİM YADA BİNDİRİM SATIRLARINDA OLACAK SADECE
        public virtual Packets Packets { get; set; }
        public Guid FormuleDetailId { get; set; } // TUTARLARIN HANGİ SIRA İLE UYGULANACAĞINI BUNUN İLE BELİRLEYECEĞİZ ÖRNEĞİN HAM -> EB -> KB
        public virtual FormuleDetail FormuleDetail { get; set; }

    }
}
