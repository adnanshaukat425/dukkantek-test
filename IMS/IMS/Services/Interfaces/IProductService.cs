using Models.Models;
using System.Threading.Tasks;
using IMS.ViewModels;

namespace IMS.Services.Interfaces
{
    public interface IProductService
    {
        public (bool, int) GetCount(int statusId);
        public Task<(bool, string)> ChangeStatusAsync(int productId, int statusId);
        public Task<(bool, string)> SellAsync(int productId);
        public Task<(bool, string)> Add(ProductVM product);
    }
}
