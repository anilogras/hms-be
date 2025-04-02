
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Trace
{
    public class TraceCommentDTO : BaseDto
    {
        public string Comment { get; set; }              // Yorum içeriği
        public DateTime CommentDate { get; set; }        // Yorum tarihi
        public Guid CommentedBy { get; set; }            // Yorumu yapan kişi ID'si
    }
}
