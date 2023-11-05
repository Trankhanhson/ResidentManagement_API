using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationProject.Repositories
{
    public class ApartmentRepository : GenericRepository<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(AuthenticationDBContext _context) : base(_context) { }

        public IQueryable<ApartmentDTO> GetAllApartment(string keyword)
        {
            var query = (from a in _context.Apartments
                         join b in _context.BuildingCategories 
                         on a.CategoryId equals b.CategoryId into a_b
                         from b in  a_b.DefaultIfEmpty()
                         where keyword == null || a.ApartmentName.Contains(keyword)
                         select new ApartmentDTO()
                         {
                             ApartmentId = a.ApartmentId,
                             ApartmentName = a.ApartmentName,
                             Floor = a.Floor,   
                             Space = a.Space,
                             CategoryId = a.CategoryId,
                             BuildingCategory = new BuildingCategoryDTO()
                             {
                                 CategoryName = b.CategoryName
                             }

                         }).AsQueryable();
            return query;
        }

        public async Task<Apartment> GetApartmentById(int id)
        {
            var apartment = await _context.Apartments.Include(a => a.BuildingCategory).FirstOrDefaultAsync(b => b.ApartmentId == id);
            return apartment;
        }

        public async Task<IEnumerable<Apartment>> GetApartmentSelect()
        {
            //var list = await _context.Apartments.Include(a => a.BuildingCategory.UrbanArea).Select(a => new Apartment()
            //{
            //    ApartmentId = a.ApartmentId,
            //    ApartmentName = a.ApartmentName,
            //    Space = a.Space,
            //    Floor = a.Floor,
            //    Building = a.Building,
            //    CategoryId = a.CategoryId,
            //    BuildingCategory = new BuildingCategory() { CategoryId = a.BuildingCategory.CategoryId, CategoryName = a.BuildingCategory.CategoryName, UrbanArea = new UrbanArea() { UrbanName = a.BuildingCategory.UrbanArea.UrbanName } }
            //}).ToListAsync();
            //return list;
            var list = await (
                from a in _context.Apartments
                join bc in _context.BuildingCategories on a.CategoryId equals bc.CategoryId
                join ua in _context.UrbanAreas on bc.UrbanId equals ua.UrbanId
                select new Apartment
                {
                    ApartmentId = a.ApartmentId,
                    ApartmentName = a.ApartmentName,
                    Space = a.Space,
                    Floor = a.Floor,
                    Building = a.Building,
                    CategoryId = a.CategoryId,
                    BuildingCategory = new BuildingCategory
                    {
                        CategoryId = bc.CategoryId,
                        CategoryName = bc.CategoryName,
                        UrbanArea = new UrbanArea { UrbanName = ua.UrbanName }
                    }
                }
            ).ToListAsync();
            return list;
        }


    }
}
