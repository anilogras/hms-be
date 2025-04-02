using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class Hospital : BaseModel
    {
        public Hospital()
        {
            HealthRecords = new List<HealthRecord>();
            RoutineCheckups = new List<RoutineCheckup>();
        }

        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPerson { get; set; }

        public virtual ICollection<HealthRecord> HealthRecords { get; set; }
        public virtual ICollection<RoutineCheckup> RoutineCheckups { get; set; }
    }
}
