using AuthenticationProject.Data;
using AuthenticationProject.Models;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IUrbanAreaRepository : IGenericRepository<UrbanArea>
    {
        IQueryable<UrbanAreaDTO> GetAllUrbanArea(string name);

        IQueryable<UrbanAreaDTO> GetSelect();
    }
}
