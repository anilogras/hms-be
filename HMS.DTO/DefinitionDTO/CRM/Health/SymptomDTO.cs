using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class SymptomDTO : BaseDto
    {
        public SymptomDTO()
        {
        }

        public string Description { get; set; }
        public virtual ICollection<HealthRecordSymptomDTO> HealthRecordSymptoms { get; set; }
    }
}
