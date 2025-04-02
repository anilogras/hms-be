using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class DailyProcedureDTO : BaseDto
    {
        public DailyProcedureDTO()
        {
            ProcedureTypes = new List<ProcedureTypeDTO>();
        }

        public Guid RoutineCheckupId { get; set; }
        public DateTime ProcedureDate { get; set; }

        public virtual RoutineCheckupDTO RoutineCheckup { get; set; }
        public virtual ICollection<ProcedureTypeDTO> ProcedureTypes { get; set; }
    }
}
