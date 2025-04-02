using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class DiagnosisDTO : BaseDto
    {
        public DiagnosisDTO()
        {
        }

        public string Description { get; set; }

        public virtual ICollection<HealthRecordDiagnosisDTO> HealthRecordDiagnoses { get; set; }
    }
}
