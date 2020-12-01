using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLayerApp.DLL.Interfaces;
using NLayerApp.DLL.ViewModels;


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
            /////////////////////////////////temp///////////////////////////
            IEnumerable<ProductViewModel> model = await _productAppService.GetProducts();
            List<ProductViewModel> modelList = model.ToList();
            return Ok(model);
        }

        [HttpGet("{type}")]
        public async Task<IActionResult> Get(string type)
        {
            return Ok(await _productAppService.GetCategoryOfProducts(type));
        }
    }
}