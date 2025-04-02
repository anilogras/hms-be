using Microsoft.EntityFrameworkCore;

namespace HMS.DataAccess.Context
{
    public partial class HMSContext : DbContext
    {
        public HMSContext() : base()
        {
        }




        /// <summary>
        /// Savechangede hard delete iptal edildi
        /// </summary>
        #region savechangeoverrides

        public void SaveChangeLoad()
        {
            var deletedEntities = ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Deleted).ToList();

            if (deletedEntities.Any())
            {
                // Silme işlemini engelle
                foreach (var entity in deletedEntities)
                {
                    // İsteğe bağlı hata fırlatma

                    // Silinmesini engelle
                    entity.State = EntityState.Unchanged;
                    throw new InvalidOperationException("The delete operation cannot be performed.");
                }
            }

            var entries = ChangeTracker.Entries()
                     .Where(e => e.State == EntityState.Added);

            foreach (var entry in entries)
            {
                var createdDateProperty = entry.Properties.FirstOrDefault(p => p.Metadata.Name == "CreatedDate");
                if (createdDateProperty != null && ( createdDateProperty.CurrentValue == null || createdDateProperty.CurrentValue.ToString() == DateTime.MinValue.ToString()))
                {
                    createdDateProperty.CurrentValue = DateTime.Now;
                }
            }

        }

        public override int SaveChanges()
        {
            SaveChangeLoad();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            SaveChangeLoad();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            SaveChangeLoad();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SaveChangeLoad();
            return base.SaveChangesAsync(cancellationToken);
        }
        #endregion
    }
}
