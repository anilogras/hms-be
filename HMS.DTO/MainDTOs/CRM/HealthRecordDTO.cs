using HMS.Dto.Base;
using HMS.DTO;
using HMS.DTO.DefinitionDTO.CRM.Health;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.CRM
{
    public class HealthRecordDTO : BaseDto
    {
        public HealthRecordDTO()
        {
            HealthRecordSymptoms = new List<HealthRecordSymptomDTO>();
            HealthRecordDiagnoses = new List<HealthRecordDiagnosisDTO>();
        }

        public Guid GuestId { get; set; }
        public DateTime IncidentDate { get; set; }
        public Guid ActionTypeId { get; set; }
        public Guid HospitalId { get; set; }
        public string Description { get; set; }
        public Guid MedicalStaffId { get; set; }

        public virtual GuestDTO Guest { get; set; }
        public virtual MedicalActionTypeDTO MedicalActionType { get; set; }
        public virtual HospitalDTO Hospital { get; set; }
        public virtual MedicalStaffDTO MedicalStaff { get; set; }
        public virtual ICollection<HealthRecordSymptomDTO> HealthRecordSymptoms { get; set; }
        public virtual ICollection<HealthRecordDiagnosisDTO> HealthRecordDiagnoses { get; set; }

    }
}
