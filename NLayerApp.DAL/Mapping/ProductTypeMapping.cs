using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NLayerApp.DAL.Model;

namespace NLayerApp.DAL.Mapping
{
    public class ProductTypeMapping : IEntityTypeConfiguration<ProductTypeEntity>
    {
        public void Configure(EntityTypeBuilder<ProductTypeEntity> builder)
        {
            builder.ToTable("ProductType");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            ConfigureUniqueKeys(builder);
            ConfigureNullableColumns(builder);
        }

        private static void ConfigureUniqueKeys(EntityTypeBuilder<ProductTypeEntity> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
        }

        private static void ConfigureNullableColumns(EntityTypeBuilder<ProductTypeEntity> builder)
        {
            builder.Property(x => x.Name).IsRequired();
        }
    }
}