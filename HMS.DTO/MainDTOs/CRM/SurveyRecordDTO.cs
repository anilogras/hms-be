
using HMS.DTO.DefinitionDTO.CRM.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.CRM
{
    public class SurveyRecordDTO : BaseDto
    {
        public SurveyRecordDTO()
        {
            SurveyResponses = new List<SurveyResponseDTO>();  // Anketin yanıtları
        }

        public string DocumentNo { get; set; }
        public string Title { get; set; }                // Anketin başlığı
        public string Description { get; set; }          // Anketin açıklaması
        public Guid SurveyThemeId { get; set; }          // İlişkili anket temasının ID'si
        public SurveyThemeDTO SurveyTheme { get; set; }     // Anket teması

        public Guid StaffId { get; set; }
        public StaffDTO Staff { get; set; }
        public bool IsOnline { get; set; }
        // Anketin yanıtları
        public List<SurveyResponseDTO> SurveyResponses { get; set; }
    }

}
