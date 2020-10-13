using Microsoft.Extensions.DependencyInjection;

using NLayerApp.DAL;
using NLayerApp.DLL.Interfaces;
using NLayerApp.DLL.Services;

namespace NLayerApp.DLL
{
    public static class Module
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddDAL();

            services.AddScoped<IProductAppService, ProductAppService>();

            return services;
        }
    }
}