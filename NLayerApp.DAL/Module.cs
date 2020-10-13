using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using NLayerApp.DAL.Repositories;
using NLayerApp.DAL.Repositories.Data;

namespace NLayerApp.DAL
{
    public static class Module
    {
        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

            services.AddEntityFrameworkNpgsql()
                .AddDbContext<ShopDbContext>(dbCtx =>
                    dbCtx.UseNpgsql("Host=localhost;Database=CoffeShop;Username=postgres;Password=admin", npgsql =>
                        npgsql.MigrationsAssembly("DbMigrator")));

            return services;
        }
    }
}