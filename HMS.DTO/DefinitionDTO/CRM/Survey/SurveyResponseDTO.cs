
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Survey
{
    public class SurveyResponseDTO : BaseDto
    {
        public Guid SurveyRecordId { get; set; }               // İlişkili anketin ID'si
        public Guid QuestionId { get; set; }              // İlişkili sorunun ID'si

        // Seçilen cevapın ID'si
        public Guid? SelectedOptionId { get; set; }       // Seçilen cevap (varsa, çoktan seçmeli için)
        public string FreeTextResponse { get; set; }      // Serbest metin yanıtı (varsa)

        // Navigation Properties
        public SurveyRecordDTO Survey { get; set; }
        public QuestionDTO Question { get; set; }
        public AnswerOptionDTO SelectedOption { get; set; }  // Seçilen cevabın referansı (varsa)
    }

}
