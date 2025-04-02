using HMS.Entities.Models.CommonModels;
using HMS.Entities.Models.Definition.FrontOffice;
using HMS.Entities.Models.MainModels.FrontOffice.FolioModels;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;
using Microsoft.EntityFrameworkCore;

namespace HMS.DataAccess.Context
{
    public partial class HMSContext
    {
        public DbSet<Company> Company { get; set; }
        public DbSet<Agency> Agency { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BoardingHouse> BoardingHouse { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Floor> Floor { get; set; }
        public DbSet<HKCode> HkCode { get; set; }
        public DbSet<Market> Market { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<PriceLocation> PriceLocation { get; set; }
        public DbSet<ReservationProperties> ReservationProperties { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomLocation> RoomLocation { get; set; }
        public DbSet<RoomProperties> RoomProperties { get; set; }
        public DbSet<Tax> Tax { get; set; }
        public DbSet<TaxSequence> TaxSequence { get; set; }
        public DbSet<VipType> VipType { get; set; }
        public DbSet<Folio> Folio{ get; set; }
        public DbSet<FolioDetail> FolioDetail { get; set; }
        public DbSet<ReservationRecord> ReservationRecord { get; set; }
        public DbSet<ReservationDetail> ReservationDetail { get; set; }
        public DbSet<ReservationDaily> ReservationDaily { get; set; }
        public DbSet<ReservationDailyPriceDetail> ReservationDailyPriceDetail { get; set; }
        public DbSet<ReservastionDailyGuest> ReservastionDailyGuest { get; set; }
        public DbSet<Rate> Rate{ get; set; }

    }
}
