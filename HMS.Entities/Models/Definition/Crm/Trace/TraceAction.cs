using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Trace
{
    public class TraceAction : BaseModel
    {
        public TraceAction()
        {
            Comments = new List<TraceComment>();
            Communication = new List<TraceCommunication>();
        }

        public TraceActionType ActionType { get; set; }             // Aksiyon tipi
        public string Description { get; set; }                     // Aksiyon açıklaması
        public DateTime ActionDate { get; set; }                    // Aksiyon tarihi
        public Guid PerformedBy { get; set; }                       // Aksiyonu yapan kişi
        public List<TraceComment> Comments { get; set; }            // Yorumlar
        public List<TraceCommunication> Communication { get; set; } // Departmanlar arası mesaj gönderme 

        public TraceStatus Status { get; set; }                     // İzleme durumu
    }

}
