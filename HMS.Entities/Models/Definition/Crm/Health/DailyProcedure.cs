using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Crm.Health
{
    public class DailyProcedure : BaseModel
    {
        public DailyProcedure()
        {
            ProcedureTypes = new List<ProcedureType>();
        }

        public Guid RoutineCheckupId { get; set; }
        public DateTime ProcedureDate { get; set; }

        public virtual RoutineCheckup RoutineCheckup { get; set; }
        public virtual ICollection<ProcedureType> ProcedureTypes { get; set; }
    }
}
