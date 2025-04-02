using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition;
using HMS.Entities.Models.Definition.Crm.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HMS.Entities.Models.MainModels.CRM
{
    public class TraceRecord : BaseModel
    {
        public TraceRecord()
        {
            Actions = new List<TraceAction>();
            GuestFeedback = new List<GuestFeedback>();

        }

        public TraceRequestType RequestType { get; set; }          // İsteği yapan kişi türü (Misafir/Personel/Departman)
        public Guid RequestorId { get; set; }                       // İsteği yapan kişi/kurum ID'si
        public Guid? ReportedByDepartmentId { get; set; }   // İşi bildiren fiziksel departman
        public PhysicalDepartment ReportedByDepartment { get; set; }   // İşi bildiren fiziksel departman
        public List<TraceAction> Actions { get; set; }              // Aksiyonlar
        public List<GuestFeedback> GuestFeedback { get; set; }              // Aksiyonlar

        public List<Guid> AssignedStaffIds { get; set; }            // Atanan personel ID'leri
        public string Description { get; set; }                     // İşin açıklaması
        public TracePriorityLevel Priority { get; set; }            // Öncelik seviyesi
        public Guid? TaskCategoryId { get; set; }             // Görev kategorisi
        public TaskCategory TaskCategory { get; set; }             // Görev kategorisi

    }
}
