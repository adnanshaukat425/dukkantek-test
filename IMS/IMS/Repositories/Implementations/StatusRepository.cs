using IMS.GenericRepositories.Implementations;
using IMS.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Models.Models;
using Models.SQL;
using System.Linq;

namespace IMS.Repositories.Implementations
{
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        public ApplicationSQLDBContext _dbContext { get; }

        public StatusRepository(ApplicationSQLDBContext dbContext, IConfiguration configuration) : base(dbContext, configuration)
        {
            _dbContext = dbContext;
        }

        public Status GetStatusByName(string name)
        {
            return _dbContext.Statuses.Where(x => x.Name.Equals(name)).FirstOrDefault();
        }
    }
}
