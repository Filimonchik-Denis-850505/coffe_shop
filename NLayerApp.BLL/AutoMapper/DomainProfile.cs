using AutoMapper;

using NLayerApp.DAL.Model;
using NLayerApp.DLL.ViewModels;

namespace NLayerApp.DLL.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Order,OrderViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}