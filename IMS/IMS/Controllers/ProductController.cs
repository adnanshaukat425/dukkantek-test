using IMS.Repositories.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        
        [HttpGet("GetCount")]
        public IActionResult GetCount(int statusId)
        {
            //Call the product service to get the count of products having the given status
            return null;
        }

        [HttpGet("ChangeStatus")]
        public IActionResult ChangeStatus(int productId, int statusId)
        {
            //Call the product serice to change the status of the given product
            return null;
        }

        [HttpGet("Sell")]
        public IActionResult Sell(int productId)
        {
            //Call the product service and sell the product
            return null;
        }
    }
}
