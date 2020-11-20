using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NLayerApp.DAL.Model;

namespace NLayerApp.DAL.Mapping
{
    public class ProductOrderMapping : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.ToTable("ProductOrder");

            builder.HasKey(x => x.Id);

            ConfigureUniqueKeys(builder);
            ConfigureForeignKeys(builder);
        }

        private static void ConfigureUniqueKeys(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasIndex(x => new {x.ProductId, x.OrderId}).IsUnique();
        }

        private static void ConfigureForeignKeys(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductOrders).HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Order)
                .WithMany(x => x.ProductOrders).HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}