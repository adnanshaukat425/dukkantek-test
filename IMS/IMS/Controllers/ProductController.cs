using IMS.Repositories.Implementations;
using IMS.Repositories.Interfaces;
using IMS.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using ViewModels.ViewModels;

namespace IMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("GetCount")]
        public IActionResult GetCountAsync(int statusId)
        {
            //Call the product service to get the count of products having the given status
            var res = _productService.GetCount(statusId);
            return ReturnResponse(res);
        }

        [HttpGet("ChangeStatus")]
        public async Task<IActionResult> ChangeStatusAsync(int productId, int statusId)
        {
            //Call the product serice to change the status of the given product
            try
            {
                var res = await _productService.ChangeStatusAsync(productId, statusId);
                return ReturnResponse(res);
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("Sell")]
        public async Task<IActionResult> SellAsync(int productId)
        {
            //Call the product service and sell the product
            var res = await _productService.SellAsync(productId);
            return ReturnResponse(res);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(ProductVM product)
        {
            var res = await _productService.Add(product);
            return ReturnResponse(res);
        }

        private IActionResult ReturnResponse<T>((bool, T) res)
        {
            return res.Item1? Ok(res.Item2) : StatusCode(404, res.Item2);
        }
    }
}
