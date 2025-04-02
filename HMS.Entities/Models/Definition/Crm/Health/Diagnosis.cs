using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class Diagnosis : BaseModel
    {
        public Diagnosis()
        {
        }

        public string Description { get; set; }

        public virtual ICollection<HealthRecordDiagnosis> HealthRecordDiagnoses { get; set; }
    }
}
