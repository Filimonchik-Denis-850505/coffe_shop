using System;

using Microsoft.EntityFrameworkCore;

using NLayerApp.DAL.Mapping;

namespace NLayerApp.DAL.EntityMapping
{
    public static class EntityMappingConfig
    {
        public static void RegisterMappings(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }


            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ProductTypeMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new DeliveryTypeMapping());
            modelBuilder.ApplyConfiguration(new PaymentTypeMapping());
            modelBuilder.ApplyConfiguration(new ProductOrderMapping());
        }
    }
}