using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class MedicalActionType : BaseModel
    {
        public MedicalActionType()
        {
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<HealthRecord> HealthRecords { get; set; }
    }
}
