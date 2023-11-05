using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationProject.Repositories
{
    public class UrbanAreaRepository : GenericRepository<UrbanArea>, IUrbanAreaRepository
    {
        public UrbanAreaRepository(AuthenticationDBContext context) : base(context)
        {
            
        }

        public IQueryable<UrbanAreaDTO> GetAllUrbanArea(string name)
        {
            IQueryable<UrbanAreaDTO> query = (from u in _context.UrbanAreas
                                           where name == null || u.UrbanName.Contains(name)
                                           join bc in _context.BuildingCategories on u.UrbanId equals bc.UrbanId into bcGroup
                              from b in bcGroup.DefaultIfEmpty()
                              join a in _context.Apartments on b.CategoryId equals a.CategoryId into aGroup
                              from apartment in aGroup.DefaultIfEmpty()
                              join ra in _context.ResidentApartment on apartment.ApartmentId equals ra.ApartmentId into raGroup
                              group raGroup by new { u.UrbanId, u.UrbanName } into g
                              select new UrbanAreaDTO
                              {
                                  UrbanId = g.Key.UrbanId,
                                  UrbanName = g.Key.UrbanName,
                                  Population = g.SelectMany(rg => rg).Count()
                              }).AsQueryable();
            return query;
        }

        public IQueryable<UrbanAreaDTO> GetSelect()
        {
            var query = (from u in _context.UrbanAreas
                         select new UrbanAreaDTO()
                         {
                             UrbanId = u.UrbanId,
                             UrbanName = u.UrbanName,
                         }).AsQueryable();
            return query;
        }
    }
}
