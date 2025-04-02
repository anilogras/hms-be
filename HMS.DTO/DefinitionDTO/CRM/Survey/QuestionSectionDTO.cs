using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Survey
{
    public class QuestionSectionDTO : BaseDto
    {
        public QuestionSectionDTO()
        {
            Questions = new List<QuestionUpperHierarchyDTO>(); // Soru bölümüne ait sorular
        }

        public string Name { get; set; }                  // Soru bölüm adı
        public string Description { get; set; }           // Soru bölüm açıklaması

        // Many-to-Many ilişki için
        public List<QuestionUpperHierarchyDTO> Questions { get; set; }
    }

}
