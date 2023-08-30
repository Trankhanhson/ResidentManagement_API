using AuthenticationProject.Models;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IBuildingCategoryRepository: IGenericRepository<BuildingCategory>
    {
        Task<IEnumerable<BuildingCategory>> GetAllBuildingCategory();
        Task<BuildingCategory> GetBuildingCategory(int id);
    }
}
