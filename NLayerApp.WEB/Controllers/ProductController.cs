using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.DLL.Interfaces;
using NLayerApp.DLL.ViewModels;
using NLayerApp.WEB.Controllers.Base;

namespace NLayerApp.WEB.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productAppService.GetProducts());
        }
    }
}