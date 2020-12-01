using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using NLayerApp.DAL.Model;
using NLayerApp.DAL.Model.Enums;

namespace NLayerApp.DAL.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);

            ConfigureUniqueKeys(builder);
            ConfigureNullableColumns(builder);
            ConfigureForeignKeys(builder);
        }

        private static void ConfigureUniqueKeys(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(x => new {x.Name, ProductType = x.ProductTypeId}).IsUnique();
        }
        
        private static void ConfigureNullableColumns(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.ProductTypeId).IsRequired()
                .HasConversion(new EnumToNumberConverter<ProductType, int>());
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.ImageURL).IsRequired();
            
        }
        
        private static void ConfigureForeignKeys(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.ProductType).WithMany()
                .HasForeignKey(x => x.ProductTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}