using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.DAL.Model;

namespace NLayerApp.DAL.Mapping
{
    public class DeliveryTypeMapping : IEntityTypeConfiguration<DeliveryTypeEntity>
    {
        public void Configure(EntityTypeBuilder<DeliveryTypeEntity> builder)
        {
            builder.ToTable("DeliveryType");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            ConfigureUniqueKeys(builder);
            ConfigureNullableColumns(builder);
        }

        private static void ConfigureUniqueKeys(EntityTypeBuilder<DeliveryTypeEntity> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
        }

        private static void ConfigureNullableColumns(EntityTypeBuilder<DeliveryTypeEntity> builder)
        {
            builder.Property(x => x.Name).IsRequired();
        }
    }
}