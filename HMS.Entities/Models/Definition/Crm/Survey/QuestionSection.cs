using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Survey
{
    public class QuestionSection : BaseModel
    {
        public QuestionSection()
        {
            Questions = new List<QuestionUpperHierarchy>(); // Soru bölümüne ait sorular
        }

        public string Name { get; set; }                  // Soru bölüm adı
        public string Description { get; set; }           // Soru bölüm açıklaması

        // Many-to-Many ilişki için
        public List<QuestionUpperHierarchy> Questions { get; set; }
    }

}
