using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;

namespace AuthenticationProject.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(AuthenticationDBContext context) : base(context)
        {
        }
    }
}
