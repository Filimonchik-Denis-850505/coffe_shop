using Microsoft.EntityFrameworkCore;

using NLayerApp.DAL.EntityMapping;

namespace NLayerApp.DAL.Repositories.Data
{
    public sealed class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options)
            : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityMappingConfig.RegisterMappings(modelBuilder);
        }
    }
}