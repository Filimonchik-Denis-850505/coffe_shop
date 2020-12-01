using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NLayerApp.DAL.Model;
using NLayerApp.DLL.Interfaces;
using NLayerApp.DLL.ViewModels;


namespace NLayerApp.WEB.Controllers
{
    [ApiController]
    [Route("api/orders")]
    
    public class OrderController : Controller
    {
        private readonly IOrderAppService _orderAppService;
        private readonly IProductAppService _productAppService;

        public OrderController(IOrderAppService orderAppService,IProductAppService productAppService)
        {
            _orderAppService = orderAppService;
            _productAppService = productAppService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            try
            {
                order.Price = await TotalPrice(order);
                return Ok(await _orderAppService.CreateOrder(order));
            }
            catch
            {
                return Ok("Error");
            }
        }

        private async Task<double> TotalPrice(Order order)
        {
            double price = 0;
            
            foreach (var t in order.ProductOrders)
            {
                var tmp = await _productAppService.GetProduct(t.ProductId);
                price += tmp.Price * t.Count;
            }
            return price;
        }
    }
}