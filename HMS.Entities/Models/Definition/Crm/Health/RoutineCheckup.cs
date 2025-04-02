using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class RoutineCheckup : BaseModel
    {
        public RoutineCheckup()
        {
            DailyProcedures = new List<DailyProcedure>();
        }

        public Guid GuestId { get; set; }
        public Guid MedicalStaffId { get; set; }
        public MedicalLocationType Location { get; set; }

        public virtual Guest Guest { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }
        public virtual ICollection<DailyProcedure> DailyProcedures { get; set; }
    }
}
