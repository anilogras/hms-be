using HMS.Entities.Models.Definition.Crm.Health;
using HMS.Entities.Models.MainModels.CRM;
using Microsoft.EntityFrameworkCore;

namespace HMS.DataAccess.Context
{
    public partial class HMSContext
    {
        public DbSet<DailyProcedure> DailyProcedure { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<HealthRecord> HealthRecord { get; set; }
        public DbSet<HealthRecordDiagnosis> HealthRecordDiagnosis { get; set; }
        public DbSet<HealthRecordSymptom> HealthRecordSymptom { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<MedicalActionType> MedicalActionType { get; set; }
        public DbSet<MedicalStaff> MedicalStaff { get; set; }
        public DbSet<MedicalStaffRole> MedicalStaffRole { get; set; }
        public DbSet<ProcedureType> ProcedureType { get; set; }
        public DbSet<Symptom> Symptom { get; set; }
    }
}
