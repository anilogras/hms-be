using HMS.Core.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Survey
{
    public class QuestionDTO : BaseDto
    {
        public QuestionDTO()
        {
            AnswerOptions = new List<AnswerOptionDTO>(); // Sorunun çoktan seçmeli cevapları
            Sections = new List<QuestionUpperHierarchyDTO>(); // Soru bölümleri ile ilişkisi
        }

        public string Text { get; set; }                 // Soru metni
        public List<AnswerOptionDTO> AnswerOptions { get; set; } // Çoktan seçmeli cevaplar

        public List<QuestionUpperHierarchyDTO> Sections { get; set; }
    }

}
