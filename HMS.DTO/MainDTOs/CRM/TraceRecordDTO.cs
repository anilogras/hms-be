using HMS.Core.Enums;
using HMS.DTO.DefinitionDTO;
using HMS.DTO.DefinitionDTO.CRM.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HMS.Entities.Models.MainModels.CRM
{
    public class TraceRecordDTO : BaseDto
    {
        public TraceRecordDTO()
        {
            Actions = new List<TraceActionDTO>();
            GuestFeedback = new List<GuestFeedbackDTO>();

        }

        public TraceRequestType RequestType { get; set; }          // İsteği yapan kişi türü (Misafir/Personel/Departman)
        public Guid RequestorId { get; set; }                       // İsteği yapan kişi/kurum ID'si
        public Guid? ReportedByDepartmentId { get; set; }   // İşi bildiren fiziksel departman
        public PhysicalDepartmentDTO ReportedByDepartment { get; set; }   // İşi bildiren fiziksel departman
        public List<TraceActionDTO> Actions { get; set; }              // Aksiyonlar
        public List<GuestFeedbackDTO> GuestFeedback { get; set; }              // Aksiyonlar

        public List<Guid> AssignedStaffIds { get; set; }            // Atanan personel ID'leri
        public string Description { get; set; }                     // İşin açıklaması
        public TracePriorityLevel Priority { get; set; }            // Öncelik seviyesi
        public Guid? TaskCategoryId { get; set; }             // Görev kategorisi
        public TaskCategoryDTO TaskCategory { get; set; }             // Görev kategorisi

    }
}
