
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Trace
{
    public class TraceCommunicationDTO : BaseDto
    {
        public Guid FromDepartmentId { get; set; } // Gönderen departman
        public Guid ToDepartmentId { get; set; } // Alan departman
        public string Message { get; set; } // Mesaj
        public DateTime CommunicationDate { get; set; } // İletişim tarihi
    }
}
