using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Survey
{
    public class ThemeQuestionResponse : BaseModel
    {
        public Guid ThemeId { get; set; }                 // İlişkili tema ID'si
        public Guid QuestionId { get; set; }              // İlişkili soru ID'si
        public Guid? AnswerOptionId { get; set; }         // Seçilen cevap (varsa)
        public string FreeTextResponse { get; set; }      // Serbest metin yanıtı (varsa)

        // Navigation Properties
        public Question Question { get; set; }            // İlişkili soru
        public AnswerOption AnswerOption { get; set; }    // Seçilen cevap (varsa)
        public SurveyTheme Theme { get; set; }            // İlişkili tema
    }
}
