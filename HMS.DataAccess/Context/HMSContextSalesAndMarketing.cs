using HMS.Entities.Models.CommonModels;
using HMS.Entities.Models.Definition.FrontOffice;
using HMS.Entities.Models.Definition.SalesAndMarketing.OutOfEntities;
using HMS.Entities.Models.MainModels.SalesAndMarketing.ContractModels;
using Microsoft.EntityFrameworkCore;

namespace HMS.DataAccess.Context
{
    public partial class HMSContext
    {
        public DbSet<OutOf> OutOf { get; set; }
        public DbSet<OutOfFloor> OutOfFloor { get; set; }
        public DbSet<OutOfRoom> OutOfFRoom { get; set; }
        public DbSet<OutOfRoomLocation> OutOfRoomLocation { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<Condition> Condition { get; set; }
        public DbSet<ContractAgency> ContractAgency { get; set; }
        public DbSet<ContractPeriod> ContractPeriod { get; set; }
        public DbSet<Packets> Packets { get; set; }
        public DbSet<PacketType> PacketType { get; set; }
        public DbSet<PeriodPrices> PeriodPrices { get; set; }
        public DbSet<PriceType> PriceType { get; set; }
        public DbSet<Formule> Formule { get; set; }
        public DbSet<FormuleDetail> FormuleDetail  { get; set; }
    }
}
