
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Survey
{
    public class SurveyThemeDTO : BaseDto
    {
        public SurveyThemeDTO()
        {
            ThemeQuestionResponse = new List<ThemeQuestionResponseDTO>(); // Temanın sorularla ilişkisi
        }

        public string Name { get; set; }                // Temanın adı
        public string Description { get; set; }         // Temanın açıklaması
        public bool Online { get; set; }

        // Temanın sorularla olan ilişkisi
        public List<ThemeQuestionResponseDTO> ThemeQuestionResponse { get; set; }
    }
}
