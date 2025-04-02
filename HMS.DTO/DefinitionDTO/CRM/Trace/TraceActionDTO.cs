using HMS.Core.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Trace
{
    public class TraceActionDTO : BaseDto
    {
        public TraceActionDTO()
        {
            Comments = new List<TraceCommentDTO>();
            Communication = new List<TraceCommunicationDTO>();
        }

        public TraceActionType ActionType { get; set; }             // Aksiyon tipi
        public string Description { get; set; }                     // Aksiyon açıklaması
        public DateTime ActionDate { get; set; }                    // Aksiyon tarihi
        public Guid PerformedBy { get; set; }                       // Aksiyonu yapan kişi
        public List<TraceCommentDTO> Comments { get; set; }            // Yorumlar
        public List<TraceCommunicationDTO> Communication { get; set; } // Departmanlar arası mesaj gönderme 

        public TraceStatus Status { get; set; }                     // İzleme durumu
    }

}
