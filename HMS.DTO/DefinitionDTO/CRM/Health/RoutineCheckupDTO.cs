using HMS.Core.Enums;
using HMS.Dto.Base;
using HMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class RoutineCheckupDTO : BaseDto
    {
        public RoutineCheckupDTO()
        {
            DailyProcedures = new List<DailyProcedureDTO>();
        }

        public Guid GuestId { get; set; }
        public Guid MedicalStaffId { get; set; }
        public MedicalLocationType Location { get; set; }

        public virtual GuestDTO Guest { get; set; }
        public virtual MedicalStaffDTO MedicalStaff { get; set; }
        public virtual ICollection<DailyProcedureDTO> DailyProcedures { get; set; }
    }
}
