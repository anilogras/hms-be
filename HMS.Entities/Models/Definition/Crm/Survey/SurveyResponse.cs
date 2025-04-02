using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Survey
{
    public class SurveyResponse : BaseModel
    {
        public Guid SurveyRecordId { get; set; }               // İlişkili anketin ID'si
        public Guid QuestionId { get; set; }              // İlişkili sorunun ID'si

        // Seçilen cevapın ID'si
        public Guid? SelectedOptionId { get; set; }       // Seçilen cevap (varsa, çoktan seçmeli için)
        public string FreeTextResponse { get; set; }      // Serbest metin yanıtı (varsa)

        // Navigation Properties
        public SurveyRecord Survey { get; set; }
        public Question Question { get; set; }
        public AnswerOption SelectedOption { get; set; }  // Seçilen cevabın referansı (varsa)
    }

}
