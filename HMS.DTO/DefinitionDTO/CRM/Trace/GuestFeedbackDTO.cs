
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Trace
{
    public class GuestFeedbackDTO : BaseDto
    {
        public Guid GuestId { get; set; } // Misafir ID'si
        public Guid TraceRecordId { get; set; } // İlişki: TraceRecord ID
        public string Feedback { get; set; } // Geri bildirim
        public DateTime FeedbackDate { get; set; } // Geri bildirim tarihi
    }
}
