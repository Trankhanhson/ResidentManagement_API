using AuthenticationProject.Data;
using AuthenticationProject.Models;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IApartmentRepository : IGenericRepository<Apartment>
    {
        Task<Apartment> GetApartmentById(int id);

        Task<IEnumerable<Apartment>> GetApartmentSelect();
    }
}
