using AuthenticationProject.Data;
using AuthenticationProject.Models;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IAddressRepository : IGenericRepository<Address>
    {
        IQueryable<AddressDTO> GetAllAddress(string keyword);

        IQueryable<AddressDTO> GetSelect();
    }
}
