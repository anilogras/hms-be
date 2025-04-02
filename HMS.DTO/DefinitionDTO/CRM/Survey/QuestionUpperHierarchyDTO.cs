
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Survey
{
    public class QuestionUpperHierarchyDTO : BaseDto
    {
        public Guid QuestionSectionId { get; set; }    // İlişkili soru bölümünün ID'si
        public Guid QuestionId { get; set; }           // İlişkili sorunun ID'si

        // Navigation Properties
        public QuestionSectionDTO QuestionSection { get; set; }
        public QuestionDTO Question { get; set; }
    }

}
