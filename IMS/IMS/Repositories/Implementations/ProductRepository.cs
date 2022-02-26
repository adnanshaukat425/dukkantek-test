using IMS.GenericRepositories.Implementations;
using IMS.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Models.Models;
using Models.SQL;

namespace IMS.Repositories.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRespository
    {
        public ApplicationSQLDBContext _dbContext { get; }

        public ProductRepository(ApplicationSQLDBContext dbContext, IConfiguration configuration) : base(dbContext, configuration)
        {
            _dbContext = dbContext;
        }
    }
}
