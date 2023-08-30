using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AuthenticationProject.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AuthenticationDBContext _context;
        public GenericRepository(AuthenticationDBContext context)
        {
            _context = context;
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public async Task<T> GetById(int id)
        {
            return  _context.Set<T>().Find(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }


        public async Task<T> Add(T entity)
        {
            var e = _context.Set<T>().Add(entity).Entity;
            return e;
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
            }
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }


    }
}
