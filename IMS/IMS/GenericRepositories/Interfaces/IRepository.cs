using System.Collections.Generic;
using System.Threading.Tasks;

namespace IMS.GenericRepositories.Interfaces
{
    public interface IRepository<T> : IRepositoryReadOnly<T> where T : class
    {
        void Insert(T model);
        void Insert(IEnumerable<T> models);
        void Update(T model);
        void Delete(T model);
        void Delete(int id);
        void Save();
        Task SaveAsync();
    }
}
