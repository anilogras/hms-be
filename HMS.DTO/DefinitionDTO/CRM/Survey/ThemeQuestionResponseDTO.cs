
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Survey
{
    public class ThemeQuestionResponseDTO : BaseDto
    {
        public Guid ThemeId { get; set; }                 // İlişkili tema ID'si
        public Guid QuestionId { get; set; }              // İlişkili soru ID'si
        public Guid? AnswerOptionId { get; set; }         // Seçilen cevap (varsa)
        public string FreeTextResponse { get; set; }      // Serbest metin yanıtı (varsa)

        // Navigation Properties
        public QuestionDTO Question { get; set; }            // İlişkili soru
        public AnswerOptionDTO AnswerOption { get; set; }    // Seçilen cevap (varsa)
        public SurveyThemeDTO Theme { get; set; }            // İlişkili tema
    }
}
