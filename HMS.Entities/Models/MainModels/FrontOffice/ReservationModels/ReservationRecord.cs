using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.FrontOffice.ReservationModels
{
    public class ReservationRecord : BaseModel
    {
        public ReservationRecord()
        {
            ReservationDetails = new List<ReservationDetail>();
        }

  
        public string? GroupVoucher { get; set; }
        public bool IsShare { get; set; }
        public bool IsGroup { get; set; }
        public virtual ICollection<ReservationDetail> ReservationDetails { get; set; }

    }
}
