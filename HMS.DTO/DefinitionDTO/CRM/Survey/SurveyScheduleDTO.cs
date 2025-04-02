using HMS.Core.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Survey
{
    public class SurveyScheduleDTO : BaseDto
    {
        public Guid SurveyThemeId { get; set; }             // İlişkili tema ID'si
        public SurveyThemeDTO SurveyTheme { get; set; }        // İlişkili temad
        public int Days { get; set; }                       // Gün sayısı
        public SurveyDayType DayType { get; set; }
        public SurveyScheduleType ScheduleType { get; set; }
    }
}
