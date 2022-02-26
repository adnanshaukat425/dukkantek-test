using IMS.Services.Interfaces;
using Models.Models;

namespace IMS.Services.Implementations
{
    public class ProductService : IProductService
    {
        public bool ChangeStatusAsync(Product product, Status status)
        {
            throw new System.NotImplementedException();
        }

        public int GetCountAsync(string statusId)
        {
            throw new System.NotImplementedException();
        }

        public bool Sell(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
