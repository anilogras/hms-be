using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Survey
{
    public class QuestionUpperHierarchy : BaseModel
    {
        public Guid QuestionSectionId { get; set; }    // İlişkili soru bölümünün ID'si
        public Guid QuestionId { get; set; }           // İlişkili sorunun ID'si

        // Navigation Properties
        public QuestionSection QuestionSection { get; set; }
        public Question Question { get; set; }
    }

}
