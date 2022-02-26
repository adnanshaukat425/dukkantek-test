using IMS.GenericRepositories.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IMS.GenericRepositories.Implementations
{
    public class RepositoryReadOnly<T> : IRepositoryReadOnly<T> where T : class
    {
        public Task<T> Get(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
