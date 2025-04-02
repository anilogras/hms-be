using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.Common;
using HMS.Entities.Models.MainModels.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class MedicalStaff : Person
    {
        public MedicalStaff()
        {
        }

        public string Specialty { get; set; }

        public Guid MedicalStaffRoleId { get; set; } 

        public virtual MedicalStaffRole MedicalStaffRole { get; set; }
        public virtual ICollection<HealthRecord> HealthRecords { get; set; }
        public virtual ICollection<RoutineCheckup> RoutineCheckups { get; set; }
    }
}
