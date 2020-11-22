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
        private readonly IProductAppService _productAppService;

        public OrderController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            try
            {
                order.Price = await TotalPrice(order);
            }
            catch
            {
                return Ok("Error");
            }
            
            return Ok(await _productAppService.CreateOrder(order));
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