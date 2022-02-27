using IMS.Mappers;
using IMS.Repositories.Interfaces;
using IMS.Services.Interfaces;
using Models.Models;
using System.Linq;
using System.Threading.Tasks;
using IMS.ViewModels;

namespace IMS.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRespository;
        private readonly IStatusRepository _statusRepository;
        public ProductService(IProductRepository productRespository, IStatusRepository statusRepository)
        {
            _productRespository = productRespository;
            _statusRepository = statusRepository;
        }
        public async Task<(bool, string)> ChangeStatusAsync(int productId, int statusId)
        {
            var product = await _productRespository.GetById(productId);
            var status = await _statusRepository.GetById(statusId);
            if (product != null)
            {
                if (status != null)
                {
                    product.StatusId = statusId;
                    _productRespository.Update(product);
                    await _productRespository.SaveAsync();
                    return (true, "Status updated successfully");
                }
                return (false, "Invalid status provided");
            }
            return (false, "No product found");
        }

        public (bool, int) GetCount(int statusId)
        {
            var count = _productRespository.Get(x => x.StatusId == statusId).Count();
            return (true, count);
        }

        public async Task<(bool, string)> SellAsync(int productId)
        {
            var status = _statusRepository.GetStatusByName("sold");
            var product = await _productRespository.GetById(productId);
            if (product != null)
            {
                product.StatusId = status.Id;
                _productRespository.Update(product);
                await _productRespository.SaveAsync();
                return (true, "Sold successfully");
            }
            return (false, "No product found");
        }

        public async Task<(bool, string)> Add(ProductVM product)
        {
            var productModel = Mapper.Map(product);
            _productRespository.Insert(productModel);
            await _productRespository.SaveAsync();
            return (true, "Product added successfully");
        }
    }
}
