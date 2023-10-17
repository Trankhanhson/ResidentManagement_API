using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;
namespace AuthenticationProject.Repositories
{
    public class ResidentRepository:GenericRepository<Resident>, IResidentRepository
    {
        public ResidentRepository(AuthenticationDBContext authenticationDBContext):base(authenticationDBContext) { }

        public async Task UpdateResident(Resident resident)
        {
            try
            {
                var entity = await _context.Resident.Include(a => a.ResidentApartments).Where(r => r.ResidentId == resident.ResidentId).FirstAsync();

                _context.RemoveRange(entity.ResidentApartments);
                _context.AddRange(resident.ResidentApartments);
                entity.Name = resident.Name;
                entity.Address = resident.Address;
                entity.Cccd = resident.Cccd;
                entity.DateOfBirth = resident.DateOfBirth;
                entity.Gender = resident.Gender;
                entity.Email = resident.Email;
                entity.PhoneNumber = resident.PhoneNumber;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while accessing the database. ", ex);
            }
        }


        public void DeleteResident(int id)
        {
            try
            {
                var entity = _context.Resident.Include(a => a.ResidentApartments).Where(a => a.ResidentId == id).FirstOrDefault();
                if (entity.ResidentApartments.Count > 0)
                {
                    _context.ResidentApartment.RemoveRange(entity.ResidentApartments);
                }
                _context.Resident.Remove(entity);

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while accessing the database. ", ex);
            }
        }

        public void DeleteMutipleResident(List<Resident> residents)
        {
            foreach(var item in residents) { 
                var entity = _context.ResidentApartment.Where(a=>a.ResidentId ==  item.ResidentId).ToList();
                if(entity.Any())
                {
                    _context.ResidentApartment.RemoveRange(entity);
                }

                _context.Resident.RemoveRange(residents);
            }
        }

        public Resident GetResidents(int id)
        {
            return _context.Resident.Include(a=>a.ResidentApartments).Where(r=>r.ResidentId == id).First();
        }

        public async Task<IEnumerable<Resident>> GetDetail(int id)
        {

            var query = from resident in _context.Resident
                        join residentapartment in _context.ResidentApartment on resident.ResidentId equals residentapartment.ResidentId
                        into ResidentApartments
                        from ra in ResidentApartments.DefaultIfEmpty()
                        join apartment in _context.Apartments on ra.ApartmentId equals apartment.ApartmentId
                        into Apartments
                        from a in Apartments.DefaultIfEmpty()
                        join building in _context.BuildingCategories on a.CategoryId equals building.CategoryId
                        into Buildings
                        from b in Buildings.DefaultIfEmpty()
                        join urban in _context.UrbanAreas on b.UrbanId equals urban.UrbanId
                        into UrbanAreas
                        from u in UrbanAreas.DefaultIfEmpty()
                        join address in _context.Addresses on b.AddressId equals address.AddressId
                        into Addresss
                        from ad in Addresss.DefaultIfEmpty()
                        where resident.ResidentId == id
                        select new
                        {
                            ResidentId = resident.ResidentId,
                            Name = resident.Name,
                            Address = resident.Address,
                            PhoneNumber = resident.PhoneNumber,
                            Email = resident.Email,
                            Cccd = resident.Cccd,
                            DateOfBirth = resident.DateOfBirth,
                            ResidentApartmentId = ra.ResidentApartmentId,
                            ApartmentId = a.ApartmentId,
                            ApartmentName = a.ApartmentName,
                            CategoryId = a.CategoryId,
                            CategoryName = b.CategoryName,
                            UrbanId = b.UrbanId,
                            AddressId = b.AddressId,
                            UrbanName = u.UrbanName,

                            City = ad.City,
                            Street = ad.Street,
                            Commune = ad.Commune,
                            District = ad.District
                        };
            var groupedQuery = from item in query
                               group item by new
                               {
                                   item.ResidentId,
                                   item.Name,
                                   item.Address,
                                   item.PhoneNumber,
                                   item.Email,
                                   item.Cccd,
                                   item.DateOfBirth
                               } into g
                               select new Resident()
                               {
                                   ResidentId = g.Key.ResidentId,
                                   Name = g.Key.Name,
                                   Address = g.Key.Address,
                                   PhoneNumber = g.Key.PhoneNumber,
                                   Email = g.Key.Email,
                                   Cccd = g.Key.Cccd,
                                   DateOfBirth = g.Key.DateOfBirth,
                                   ResidentApartments = g.Select(ra => new ResidentApartment
                                   {

                                       ResidentApartmentId = ra.ResidentApartmentId,
                                       ResidentId = ra.ResidentId,
                                       Apartment = new Apartment
                                       {
                                           ApartmentId = ra.ApartmentId,
                                           ApartmentName = ra.ApartmentName,
                                           CategoryId = ra.CategoryId,
                                           BuildingCategory = new BuildingCategory
                                           {
                                               CategoryId = ra.CategoryId,
                                               CategoryName = ra.CategoryName,
                                               UrbanId = ra.UrbanId,
                                               AddressId = ra.AddressId,

                                               UrbanArea = new UrbanArea
                                               {
                                                   UrbanId = ra.UrbanId,
                                                   UrbanName = ra.UrbanName
                                               },
                                               Address = new Address
                                               {
                                                   AddressId = ra.AddressId,
                                                   Street = ra.Street,
                                                   City = ra.City,
                                                   Commune = ra.Commune,
                                                   District = ra.District
                                               }
                                           }
                                       }

                                   }).ToList()
                               };
            var r = await groupedQuery.ToListAsync();
            return r;
        }

        public IQueryable<ResidentDTO> GetAllResident(string keyword)
        {
            var query = (from r in _context.Resident
                         select new ResidentDTO()
                         {
                             ResidentId = r.ResidentId,
                             Cccd = r.Cccd,
                             DateOfBirth = r.DateOfBirth,
                             PhoneNumber = r.PhoneNumber,
                             Email = r.Email,
                             Address = r.Address,
                             Name = r.Name,
                             Gender = r.Gender
                         });
            return query.AsQueryable();
        }
    }
}
