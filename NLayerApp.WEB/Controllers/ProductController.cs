using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.DLL.Interfaces;


namespace NLayerApp.WEB.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            return Ok(await _productAppService.GetProducts());
        }

        [HttpGet("{type}")]
        public async Task<IActionResult> Get(string type)
        {
            return Ok(await _productAppService.GetCategoryOfProducts(type));
        }
    }
}