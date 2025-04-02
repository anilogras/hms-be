using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.Crm.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.CRM
{
    public class SurveyRecord : BaseModel
    {
        public SurveyRecord()
        {
            SurveyResponses = new List<SurveyResponse>();  // Anketin yanıtları
        }

        public string DocumentNo { get; set; }
        public string Title { get; set; }                // Anketin başlığı
        public string Description { get; set; }          // Anketin açıklaması
        public Guid SurveyThemeId { get; set; }          // İlişkili anket temasının ID'si
        public SurveyTheme SurveyTheme { get; set; }     // Anket teması

        public Guid StaffId { get; set; }
        public Staff Staff { get; set; }
        public bool IsOnline { get; set; }
        // Anketin yanıtları
        public List<SurveyResponse> SurveyResponses { get; set; }
    }

}
