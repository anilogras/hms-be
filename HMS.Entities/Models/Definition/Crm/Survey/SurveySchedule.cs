using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Survey
{
    public class SurveySchedule : BaseModel
    {
        public Guid SurveyThemeId { get; set; }             // İlişkili tema ID'si
        public SurveyTheme SurveyTheme { get; set; }        // İlişkili temad
        public int Days { get; set; }                       // Gün sayısı
        public SurveyDayType DayType { get; set; }
        public SurveyScheduleType ScheduleType { get; set; }
    }
}
