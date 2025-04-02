using Microsoft.EntityFrameworkCore;

namespace HMS.DataAccess.Context
{
    public partial class HMSContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=31.7.33.70;Port=6543;Database=batuhms2;Username=postgres;Password=1234Acucobol*-+");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var oldTableName = entity.GetTableName();
                if (oldTableName != null)
                {
                    entity.SetTableName(oldTableName.ToLower());
                }
            }

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var datetimeProps = entity.GetProperties()
                    .Where(p => 
                    (p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?))
                    && (!p.GetAnnotations().Any(a =>
                         a.Name == "Relational:ColumnType" &&
                         a.Value?.ToString() == "date"))
                    );

                foreach (var property in datetimeProps)
                {
                    property.SetColumnType("timestamp without time zone");
                }
            }

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var stringProps = entity.GetProperties()
                    .Where(p => p.Name == "Id" && p.ClrType == typeof(Guid));

                foreach (var property in stringProps)
                {
                    property.SetDefaultValueSql("gen_random_uuid()");
                }
            }



            base.OnModelCreating(modelBuilder);
        }


    }
}
