using System.Collections.Generic;
using System.Threading.Tasks;
using NLayerApp.DAL.Model.Enums;
using NLayerApp.DLL.ViewModels;

namespace NLayerApp.DLL.Interfaces
{
    public interface IProductAppService
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();
        Task<IEnumerable<ProductViewModel>> GetCategoryOfProducts(string type);
    }
}