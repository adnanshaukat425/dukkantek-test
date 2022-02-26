using IMS.GenericRepositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Models.SQL;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IMS.GenericRepositories.Implementations
{
    public class RepositoryReadOnly<T> : IRepositoryReadOnly<T> where T : class
    {
        private readonly ApplicationSQLDBContext _dbContext;
        public IConfiguration _configuration { get; }

        public RepositoryReadOnly(ApplicationSQLDBContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null)
        {
            return _dbContext.Set<T>().Where(filter);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsQueryable();
        }
    }
}
