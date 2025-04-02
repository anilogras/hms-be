using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Survey
{
    public class SurveyTheme : BaseModel
    {
        public SurveyTheme()
        {
            ThemeQuestionResponse = new List<ThemeQuestionResponse>(); // Temanın sorularla ilişkisi
        }

        public string Name { get; set; }                // Temanın adı
        public string Description { get; set; }         // Temanın açıklaması
        public bool Online { get; set; }

        // Temanın sorularla olan ilişkisi
        public List<ThemeQuestionResponse> ThemeQuestionResponse { get; set; }
    }
}
