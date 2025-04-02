using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Complaint
{
    public class ComplaintAction : BaseModel
    {
        public Guid ComplaintId { get; set; }
        public DateTime LogDate { get; set; } // Kayıt tarihi
        public string ActionDescription { get; set; } // Hareket açıklaması
        public Guid StaffId { get; set; }

        public virtual ComplaintRecord ComplaintRecord { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
