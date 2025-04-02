using HMS.Core.Enums;
using HMS.Dto.Base;
using HMS.DTO.DefinitionDTO.CRM.Complaint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.CRM
{
    //Reklamasyon
    public class ComplaintRecordDTO : BaseDto
    {
        public Guid GuestId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public ComplaintStatus Status { get; set; }
        public string Resolution { get; set; }
        public DateTime? ResolutionDate { get; set; }

        public Guid StaffId { get; set; }
        public string Feedback { get; set; }
        public bool IsEscalated { get; set; }
        public string EscalationReason { get; set; }
        public DateTime? EscalationDate { get; set; }
        public string Comments { get; set; }

        public virtual GuestDTO Guest { get; set; }
        public virtual StaffDTO Staff { get; set; }

        public ICollection<ComplaintActionDTO> ComplaintAction { get; set; }
    }
}
