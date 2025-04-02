using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class Symptom : BaseModel
    {
        public Symptom()
        {
        }

        public string Description { get; set; }
        public virtual ICollection<HealthRecordSymptom> HealthRecordSymptoms { get; set; }
    }
}
