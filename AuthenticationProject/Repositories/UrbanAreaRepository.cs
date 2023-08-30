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

        public async Task<IEnumerable<UrbanArea>> GetAllUrbanArea()
        {
            var list = await (from u in _context.UrbanAreas
                              join bc in _context.BuildingCategories on u.UrbanId equals bc.UrbanId into bcGroup
                              from b in bcGroup.DefaultIfEmpty()
                              join a in _context.Apartments on b.CategoryId equals a.CategoryId into aGroup
                              from apartment in aGroup.DefaultIfEmpty()
                              join ra in _context.ResidentApartment on apartment.ApartmentId equals ra.ApartmentId into raGroup
                              group raGroup by new { u.UrbanId, u.UrbanName } into g
                              select new UrbanArea
                              {
                                  UrbanId = g.Key.UrbanId,
                                  UrbanName = g.Key.UrbanName,
                                  Population = g.SelectMany(rg => rg).Count()
                              }).ToListAsync();
            return list;
            //var list = await _context.UrbanAreas.Include(a=>a.buildingCategories).ThenInclude(b=>b.Apartments)
            //    .ThenInclude(c=>c.ResidentApartments).Select(a=>new UrbanArea()
            //{
            //    UrbanId = a.UrbanId,
            //    UrbanName = a.UrbanName,
            //    Population = a.buildingCategories.SelectMany(b=>b.Apartments).SelectMany(c=>c.ResidentApartments).Count()
            //}).ToListAsync();
            //return list;
        }
    }
}
