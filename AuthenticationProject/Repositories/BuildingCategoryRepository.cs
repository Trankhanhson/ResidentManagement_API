using AuthenticationProject.Data;
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

        public IQueryable<BuildingCategoryDTO> GetAllBuildingCategory(string keyword)
        {
            var query = (from b in _context.BuildingCategories
                              join u in _context.UrbanAreas on
                              b.UrbanId equals u.UrbanId into b_u 
                              from u in b_u.DefaultIfEmpty()
                              join a in _context.Addresses
                              on b.AddressId equals a.AddressId into b_a
                              from a in b_a.DefaultIfEmpty()
                              where keyword == null || 
                              (b.CategoryName.Contains(keyword) || u.UrbanName.Contains(keyword))
                              select new BuildingCategoryDTO
                              {
                                  CategoryId = b.CategoryId,
                                  UrbanId = b.UrbanId,
                                  AddressId = b.AddressId,
                                  CategoryName = b.CategoryName,
                                  UrbanArea = new UrbanAreaDTO
                                  {
                                      UrbanId = u.UrbanId,
                                      UrbanName = u.UrbanName
                                  },
                                  Address = new AddressDTO
                                  {
                                      AddressId = a.AddressId,
                                      City = a.City,
                                      Street = a.Street,
                                      Commune = a.Commune,
                                      District = a.District
                                  }
                              }
           ).AsQueryable();
            return query;
        }

        public async Task<BuildingCategory> GetBuildingCategory(int id)
        {
            var entity = await _context.BuildingCategories.Include(a=>a.UrbanArea).Include(c=>c.Address).Where(b=>b.CategoryId == id).FirstAsync();
            return entity;
        }

        public IQueryable<BuildingCategoryDTO> GetSelect()
        {
            var query = (from b in _context.BuildingCategories
                         join u in _context.UrbanAreas
                         on b.UrbanId equals u.UrbanId
                         into b_u
                         from u in b_u.DefaultIfEmpty()
                         select new BuildingCategoryDTO()
                         {
                             CategoryId = b.CategoryId,
                             CategoryName = b.CategoryName,
                             UrbanArea = new UrbanAreaDTO() { UrbanName = u.UrbanName }
                         }).AsQueryable();
            return query;
        }
    }
}
