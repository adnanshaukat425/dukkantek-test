using Models.Models;

namespace IMS.Services.Interfaces
{
    public interface IProductService
    {
        public int GetCountAsync(string statusId);
        public bool ChangeStatusAsync(Product product, Status status);
        public bool Sell(Product product);
    }
}
