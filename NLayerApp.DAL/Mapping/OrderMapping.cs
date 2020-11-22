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
            ConfigureNotNullableColumns(builder);
            ConfigureForeignKeys(builder);
        }

        private static void ConfigureUniqueKeys(EntityTypeBuilder<Order> builder)
        {
            builder.HasIndex(x => x.Name);
        }

        private static void ConfigureNotNullableColumns(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Name).IsRequired(); //обязательно должно иметь значение [Required]
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.DeliveryTypeId).IsRequired()
                .HasConversion(new EnumToNumberConverter<DeliveryType, int>());
            builder.Property(x => x.PaymentTypeId).IsRequired()
                .HasConversion(new EnumToNumberConverter<PaymentType, int>());
        }

        private static void ConfigureForeignKeys(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(x => x.PaymentType)
                .WithMany().HasForeignKey(x => x.PaymentTypeId).OnDelete(DeleteBehavior.Cascade); 
            builder.HasOne(x => x.DeliveryType)
                .WithMany().HasForeignKey(x => x.DeliveryTypeId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}