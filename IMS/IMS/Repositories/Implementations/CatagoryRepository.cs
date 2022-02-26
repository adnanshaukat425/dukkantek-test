using IMS.Repositories.Interfaces;
using Models.Models;
using IMS.GenericRepositories.Implementations;
using Models.SQL;
using Microsoft.Extensions.Configuration;

namespace IMS.Repositories.Implementations
{
    public class CatagoryRepository : Repository<Catagory>, ICatagoryRepository
    {
        public ApplicationSQLDBContext _dbContext { get; }

        public CatagoryRepository(ApplicationSQLDBContext dbContext, IConfiguration configuration) : base(dbContext, configuration)
        {
            _dbContext = dbContext;
        }

    }
}
