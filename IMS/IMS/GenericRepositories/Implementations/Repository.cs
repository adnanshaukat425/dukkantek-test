using IMS.GenericRepositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Models.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IMS.GenericRepositories.Implementations
{
    public class Repository<T> : RepositoryReadOnly<T>, IRepository<T> where T : class
    {
        private readonly ApplicationSQLDBContext _dbContext;

        public Repository(ApplicationSQLDBContext dbContext, IConfiguration configuration) : base(dbContext, configuration)
        {
            _dbContext = dbContext;
        }
        public void Delete(T model)
        {
            _dbContext.Set<T>().Remove(model);
        }

        public void Delete(int id)
        {
            T entity = _dbContext.Set<T>().Find(id);
            _dbContext.Set<T>().Remove(entity);
        }

        public void Insert(T model)
        {
            _dbContext.Set<T>().Add(model);
        }

        public void Insert(IEnumerable<T> models)
        {
            _dbContext.Set<T>().AddRange(models);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
