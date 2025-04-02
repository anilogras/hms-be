using HMS.Entities.Models;
using HMS.Entities.Models.CommonModels;
using HMS.Entities.Models.Definition.Common.Contact;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.EntityFrameworkCore;

namespace HMS.DataAccess.Context
{
    public partial class HMSContext
    {
        public DbSet<Enterprise> Enterprise { get; set; }
        public DbSet<Referance> Referance { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<CompanyParemeters> CompanyParemeters { get; set; }
        public DbSet<CompanyDepartments> CompanyDepartments{ get; set; }
        public DbSet<CompanyDefaultDepartments> CompanyDefaultDepartments { get; set; }
        public DbSet<CompanyDepartmentPeriod> CompanyDepartmentPeriod { get; set; }

    }
}
