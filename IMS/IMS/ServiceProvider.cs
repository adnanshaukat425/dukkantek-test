using IMS.GenericRepositories.Implementations;
using IMS.GenericRepositories.Interfaces;
using IMS.Repositories.Interfaces;
using IMS.Services.Implementations;
using IMS.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using IMS.Repositories.Implementations;
using IMS.Services.Hosted;
using IMS.Setup;

namespace IMS
{
    public class ServiceProvider
    {
        public ServiceProvider(IServiceCollection services)
        {
            services.AddHostedService<DataSeederSetup>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<ICatagoryRepository, CatagoryRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<DataSeeder>();
        }
    }
}
