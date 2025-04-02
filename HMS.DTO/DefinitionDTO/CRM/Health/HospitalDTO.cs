using HMS.Dto.Base;
using HMS.DTO.MainDTOs.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class HospitalDTO : BaseDto
    {
        public HospitalDTO()
        {
            HealthRecords = new List<HealthRecordDTO>();
            RoutineCheckups = new List<RoutineCheckupDTO>();
        }

        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPerson { get; set; }

        public virtual ICollection<HealthRecordDTO> HealthRecords { get; set; }
        public virtual ICollection<RoutineCheckupDTO> RoutineCheckups { get; set; }
    }
}
