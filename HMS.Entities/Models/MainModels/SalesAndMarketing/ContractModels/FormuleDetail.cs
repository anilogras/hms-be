using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Entities.Models.Base;

namespace HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels
{
    public class FormuleDetail : EnBaseModel
    {
        public Guid FormuleId { get; set; }
        public virtual Formule Formule { get; set; }
        public Guid PacketTypeId { get; set; }
        public virtual PacketType PacketType { get; set; }
        public int Order { get; set; }
        public bool Cumulative { get; set; }
    }
}
