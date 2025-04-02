using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Trace
{
    public class TraceCommunication : BaseModel
    {
        public Guid FromDepartmentId { get; set; } // Gönderen departman
        public Guid ToDepartmentId { get; set; } // Alan departman
        public string Message { get; set; } // Mesaj
        public DateTime CommunicationDate { get; set; } // İletişim tarihi
    }
}
