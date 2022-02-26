using IMS.GenericRepositories.Implementations;
using IMS.GenericRepositories.Interfaces;
using IMS.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IMS
{
    public class ServiceProvider
    {
        public ServiceProvider(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
