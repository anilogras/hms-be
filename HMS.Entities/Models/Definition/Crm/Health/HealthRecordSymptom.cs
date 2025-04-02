using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class HealthRecordSymptom : BaseModel
    {
        public Guid HealthRecordId { get; set; }
        public Guid SymptomId { get; set; }

        public virtual HealthRecord HealthRecord { get; set; }
        public virtual Symptom Symptom { get; set; }
    }
}
