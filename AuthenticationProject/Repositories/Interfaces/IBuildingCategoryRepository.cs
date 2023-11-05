using AuthenticationProject.Data;
using AuthenticationProject.Models;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IBuildingCategoryRepository: IGenericRepository<BuildingCategory>
    {
        IQueryable<BuildingCategoryDTO> GetAllBuildingCategory(string keyword);
        Task<BuildingCategory> GetBuildingCategory(int id);

        IQueryable<BuildingCategoryDTO> GetSelect();
    }
}
