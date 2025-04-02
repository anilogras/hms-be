using HMS.Dto.Base;
using HMS.DTO.MainDTOs.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class HealthRecordSymptomDTO : BaseDto
    {
        public Guid HealthRecordId { get; set; }
        public Guid SymptomId { get; set; }

        public virtual HealthRecordDTO HealthRecord { get; set; }
        public virtual SymptomDTO Symptom { get; set; }
    }
}
