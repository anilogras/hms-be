using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Survey
{
    public class Question : BaseModel
    {
        public Question()
        {
            AnswerOptions = new List<AnswerOption>(); // Sorunun çoktan seçmeli cevapları
            Sections = new List<QuestionUpperHierarchy>(); // Soru bölümleri ile ilişkisi
        }

        public string Text { get; set; }                 // Soru metni
        public List<AnswerOption> AnswerOptions { get; set; } // Çoktan seçmeli cevaplar

        public List<QuestionUpperHierarchy> Sections { get; set; }
    }

}
