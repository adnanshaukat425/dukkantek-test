using IMS.Setup;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IMS.Services.Hosted
{
    public class DataSeederSetup : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        public DataSeederSetup(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (IServiceScope scope = _serviceProvider.CreateScope())
            {
                DataSeeder seeder = scope.ServiceProvider.GetRequiredService<DataSeeder>();
                await seeder.SeedAsync();
            }
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
        }
    }
}
