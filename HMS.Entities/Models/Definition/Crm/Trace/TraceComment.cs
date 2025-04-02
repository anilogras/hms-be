using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Trace
{
    public class TraceComment : BaseModel
    {
        public string Comment { get; set; }              // Yorum içeriği
        public DateTime CommentDate { get; set; }        // Yorum tarihi
        public Guid CommentedBy { get; set; }            // Yorumu yapan kişi ID'si
    }
}
