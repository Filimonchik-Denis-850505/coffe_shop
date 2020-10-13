using AutoMapper;

using NLayerApp.DAL.Model;
using NLayerApp.DLL.ViewModels;

namespace NLayerApp.DLL.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name));
        }
    }
}