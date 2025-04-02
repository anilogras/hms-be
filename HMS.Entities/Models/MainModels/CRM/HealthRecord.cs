using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.Crm.Health;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.MainModels.CRM
{
    public class HealthRecord : BaseModel
    {
        public HealthRecord()
        {
            HealthRecordSymptoms = new List<HealthRecordSymptom>();
            HealthRecordDiagnoses = new List<HealthRecordDiagnosis>();
        }

        public Guid GuestId { get; set; }
        public DateTime IncidentDate { get; set; }
        public Guid ActionTypeId { get; set; }
        public Guid HospitalId { get; set; }
        public string Description { get; set; }
        public Guid MedicalStaffId { get; set; }

        public virtual Guest Guest { get; set; }
        public virtual MedicalActionType MedicalActionType { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }
        public virtual ICollection<HealthRecordSymptom> HealthRecordSymptoms { get; set; }
        public virtual ICollection<HealthRecordDiagnosis> HealthRecordDiagnoses { get; set; }

    }
}
