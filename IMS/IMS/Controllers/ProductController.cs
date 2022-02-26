using Microsoft.AspNetCore.Mvc;

namespace IMS.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetCount(int statusId)
        {
            //Call the product service to get the count of products having the given status
            return null;
        }

        public IActionResult ChangeStatus(int productId, int statusId)
        {
            //Call the product serice to change the status of the given product
            return null;
        }

        public IActionResult Sell(int productId)
        {
            //Call the product service and sell the product
            return null;
        }
    }
}
