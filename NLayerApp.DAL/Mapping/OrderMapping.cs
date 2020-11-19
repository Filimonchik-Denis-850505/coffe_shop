using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using NLayerApp.DAL.Model;
using NLayerApp.DAL.Model.Enums;

namespace NLayerApp.DAL.Mapping
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            ConfigureUniqueKeys(builder);
            ConfigureNullableColumns(builder);
            ConfigureForeignKeys(builder);
        }

        private static void ConfigureUniqueKeys(EntityTypeBuilder<Order> builder)
        {
            builder.HasIndex(x => new {x.Name, ProductType = x.ProductTypeId}).IsUnique();
        }
        
        private static void ConfigureNullableColumns(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Name).IsRequired(); //обязательно должно иметь значение [Required]
            builder.Property(x => x.ProductTypeId).IsRequired()
                .HasConversion(new EnumToNumberConverter<ProductType, int>());
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).IsRequired();
        }
        
        private static void ConfigureForeignKeys(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(x => x.ProductType).WithMany()
                .HasForeignKey(x => x.ProductTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}