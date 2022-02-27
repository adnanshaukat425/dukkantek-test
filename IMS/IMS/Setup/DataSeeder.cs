using IMS.Pocos;
using IMS.Repositories.Interfaces;
using System.Threading.Tasks;

namespace IMS.Setup
{
    public class DataSeeder
    {
        public readonly SeedData _seedData;
        public readonly IProductRepository _productRespository;
        public readonly IStatusRepository _statusRepository;
        public readonly ICatagoryRepository _catagoryRespository;
        public DataSeeder(SeedData seedData, IProductRepository productRespository, IStatusRepository statusRepository, ICatagoryRepository catagoryRepository)
        {
            _seedData = seedData;
            _productRespository = productRespository;
            _statusRepository = statusRepository;
            _catagoryRespository = catagoryRepository;
        }

        public async Task SeedAsync()
        {
            if (_seedData.Seed)
            {
                await SeedCatagories();
                await SeedStatus();
                await SeedProduct();
            }
        }

        public async Task SeedCatagories()
        {
            if (_seedData.Catagories != null)
            {
                foreach (var item in _seedData.Catagories)
                {
                    var catagory = await _catagoryRespository.GetById(item.Id);
                    if (catagory != null)
                    {
                        catagory.Name = item.Name;
                        _catagoryRespository.Update(catagory);
                    }
                    else
                    {
                        item.Id = 0;
                        _catagoryRespository.Insert(item);
                    }
                }
                await _catagoryRespository.SaveAsync();
            }
        }

        public async Task SeedStatus()
        {
            if (_seedData.Statuses != null)
            {
                foreach (var item in _seedData.Statuses)
                {
                    var status = await _statusRepository.GetById(item.Id);
                    if (status != null)
                    {
                        status.Name = item.Name;
                        _statusRepository.Update(status);
                    }
                    else
                    {
                        item.Id = 0;
                        _statusRepository.Insert(item);
                    }
                }
                await _statusRepository.SaveAsync();
            }
        }

        public async Task SeedProduct()
        {
            if (_seedData.Products != null)
            {
                foreach (var item in _seedData.Products)
                {
                    var product = await _productRespository.GetById(item.Id);
                    if (product != null)
                    {
                        product.Name = item.Name;
                        _productRespository.Update(product);
                    }
                    else
                    {
                        item.Id = 0;
                        _productRespository.Insert(item);
                    }
                }
                await _productRespository.SaveAsync();
            }
        }
    }
}
