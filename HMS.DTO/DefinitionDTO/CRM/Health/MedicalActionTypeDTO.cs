using HMS.Dto.Base;
using HMS.DTO.MainDTOs.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class MedicalActionTypeDTO : BaseDto
    {
        public MedicalActionTypeDTO()
        {
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<HealthRecordDTO> HealthRecords { get; set; }
    }
}
