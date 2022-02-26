using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IMS.GenericRepositories.Interfaces
{
    public interface IRepositoryReadOnly<T> where T: class
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null);
    }
}
