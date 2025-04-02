using HMS.Dto.Base;
using HMS.DTO.MainDTOs.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class HealthRecordDiagnosisDTO : BaseDto
    {
        public Guid HealthRecordId { get; set; }
        public Guid DiagnosisId { get; set; }

        public virtual HealthRecordDTO HealthRecord { get; set; }
        public virtual DiagnosisDTO Diagnosis { get; set; }
    }
}
