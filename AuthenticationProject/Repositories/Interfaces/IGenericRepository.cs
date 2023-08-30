using System.Linq.Expressions;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);

        void Complete();
    }
}
