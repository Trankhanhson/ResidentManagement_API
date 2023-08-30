using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationProject.Repositories
{
    public class BuildingCategoryRepository : GenericRepository<BuildingCategory>, IBuildingCategoryRepository
    {
        public BuildingCategoryRepository(AuthenticationDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<BuildingCategory>> GetAllBuildingCategory()
        {
            //var list = await _context.BuildingCategories.Include(a => a.UrbanArea).Include(b => b.Address).Select(c => new BuildingCategory()
            //{
            //    CategoryId = c.CategoryId,
            //    CategoryName = c.CategoryName,
            //    UrbanId = c.UrbanId,
            //    AddressId = c.AddressId,
            //    UrbanArea = new UrbanArea() { UrbanName = c.UrbanArea.UrbanName },
            //    Address = new Address() { Street = c.Address.Street, Commune = c.Address.Commune, District = c.Address.District, City = c.Address.City },
            //}).ToListAsync();
            //return list;
            var list = await (from b in _context.BuildingCategories
                              join u in _context.UrbanAreas on
            b.UrbanId equals u.UrbanId
                              join a in _context.Addresses on b.AddressId equals a.AddressId
                              select new BuildingCategory
                              {
                                  CategoryId = b.CategoryId,
                                  UrbanId = b.UrbanId,
                                  AddressId = b.AddressId,
                                  CategoryName = b.CategoryName,
                                  UrbanArea = new UrbanArea
                                  {
                                      UrbanId = u.UrbanId,
                                      UrbanName = u.UrbanName
                                  },
                                  Address = new Address
                                  {
                                      AddressId = a.AddressId,
                                      City = a.City,
                                      Street = a.Street,
                                      Commune = a.Commune,
                                      District = a.District
                                  }
                              }
           ).ToListAsync();
            return list;
        }

        public async Task<BuildingCategory> GetBuildingCategory(int id)
        {
            var entity = await _context.BuildingCategories.Include(a=>a.UrbanArea).Include(c=>c.Address).Where(b=>b.CategoryId == id).FirstAsync();
            return entity;
        }
    }
}
