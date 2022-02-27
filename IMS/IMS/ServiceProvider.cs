using IMS.GenericRepositories.Implementations;
using IMS.GenericRepositories.Interfaces;
using IMS.Repositories.Interfaces;
using IMS.Services.Implementations;
using IMS.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using IMS.Repositories.Implementations;

namespace IMS
{
    public class ServiceProvider
    {
        public ServiceProvider(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductRespository, ProductRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
