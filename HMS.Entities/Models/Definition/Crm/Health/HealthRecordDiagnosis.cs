using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class HealthRecordDiagnosis : BaseModel
    {
        public Guid HealthRecordId { get; set; }
        public Guid DiagnosisId { get; set; }

        public virtual HealthRecord HealthRecord { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
    }
}
