using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;

namespace AuthenticationProject.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(AuthenticationDBContext context) : base(context)
        {
        }

        public IQueryable<AddressDTO> GetAllAddress(string keyword)
        {
            var query = (from a in _context.Addresses where 
                         keyword == null || a.City.Contains(keyword) || a.District.Contains(keyword) || a.Commune.Contains(keyword)
                         select new AddressDTO()
                         {
                             AddressId = a.AddressId,
                             City = a.City,
                             District = a.District,
                             Commune = a.Commune,   
                             Street = a.Street
                         })
                         
                         .AsQueryable();
            return query;
        }

        public IQueryable<AddressDTO> GetSelect()
        {
            var query  = (from a in _context.Addresses
                          select new AddressDTO()
                          {
                              AddressId = a.AddressId,
                              City = a.City,
                              District = a.District,
                              Commune = a.Commune,
                              Street = a.Street
                          }).AsQueryable();
            return query;
        }
    }
}
