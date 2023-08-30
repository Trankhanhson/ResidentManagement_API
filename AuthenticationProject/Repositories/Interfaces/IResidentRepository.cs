
using AuthenticationProject.Models;
using System.Collections;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IResidentRepository: IGenericRepository<Resident>
    {
        Task UpdateResident(Resident resident);

        void DeleteResident(int id);

        void DeleteMutipleResident(List<Resident> residents);

        Resident GetResidents(int id);
        Task<IEnumerable<Resident>> GetDetail(int id);
    }
}   
