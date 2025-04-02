using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Trace
{
    public class GuestFeedback : BaseModel
    {
        public Guid GuestId { get; set; } // Misafir ID'si
        public Guid TraceRecordId { get; set; } // İlişki: TraceRecord ID
        public string Feedback { get; set; } // Geri bildirim
        public DateTime FeedbackDate { get; set; } // Geri bildirim tarihi
    }
}
