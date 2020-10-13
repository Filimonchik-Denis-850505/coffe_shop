using System.Collections.Generic;
using System.Threading.Tasks;

using NLayerApp.DLL.ViewModels;

namespace NLayerApp.DLL.Interfaces
{
    public interface IProductAppService
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();
    }
}