using System.Collections.Generic;
using System.Threading.Tasks;
using NLayerApp.DAL.Model;
using NLayerApp.DLL.ViewModels;

namespace NLayerApp.DLL.Interfaces
{
    public interface IOrderAppService
    {
        Task<OrderViewModel> CreateOrder(Order order);
    }
}