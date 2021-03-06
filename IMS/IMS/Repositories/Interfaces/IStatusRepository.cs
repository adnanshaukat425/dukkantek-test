using IMS.GenericRepositories.Interfaces;
using Models.Models;

namespace IMS.Repositories.Interfaces
{
    public interface IStatusRepository : IRepository<Status>
    {
        Status GetStatusByName(string name);
    }
}
