using HMS.DTO.DefinitionDTO.Common;
using HMS.DTO.MainDTOs.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class MedicalStaffDTO : PersonDTO
    {
        public MedicalStaffDTO()
        {
        }

        public string Specialty { get; set; }

        public Guid MedicalStaffRoleId { get; set; }

        public virtual MedicalStaffRoleDTO MedicalStaffRole { get; set; }
        public virtual ICollection<HealthRecordDTO> HealthRecords { get; set; }
        public virtual ICollection<RoutineCheckupDTO> RoutineCheckups { get; set; }
    }
}
