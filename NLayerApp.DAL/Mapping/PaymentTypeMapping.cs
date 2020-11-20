using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NLayerApp.DAL.Model;

namespace NLayerApp.DAL.Mapping
{
    public class PaymentTypeMapping : IEntityTypeConfiguration<PaymentTypeEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentTypeEntity> builder)
        {
            builder.ToTable("PaymentType");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            ConfigureUniqueKeys(builder);
            ConfigureNullableColumns(builder);
        }

        private static void ConfigureUniqueKeys(EntityTypeBuilder<PaymentTypeEntity> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
        }

        private static void ConfigureNullableColumns(EntityTypeBuilder<PaymentTypeEntity> builder)
        {
            builder.Property(x => x.Name).IsRequired();
        }
    }
}