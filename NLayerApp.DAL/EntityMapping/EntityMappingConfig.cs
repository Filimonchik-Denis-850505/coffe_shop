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
        }
    }
}