using AuthenticationProject.Models;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IUrbanAreaRepository : IGenericRepository<UrbanArea>
    {
        Task<IEnumerable<UrbanArea>> GetAllUrbanArea();
    }
}
