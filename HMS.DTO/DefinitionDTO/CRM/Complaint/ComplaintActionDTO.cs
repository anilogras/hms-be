using HMS.Core.Enums;
using HMS.Dto.Base;
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Complaint
{
    public class ComplaintActionDTO : BaseDto
    {
        public Guid ComplaintId { get; set; }
        public DateTime LogDate { get; set; } // Kayıt tarihi
        public string ActionDescription { get; set; } // Hareket açıklaması
        public Guid StaffId { get; set; }

        public virtual ComplaintRecordDTO ComplaintRecord { get; set; }
        public virtual StaffDTO Staff { get; set; }
    }
}
