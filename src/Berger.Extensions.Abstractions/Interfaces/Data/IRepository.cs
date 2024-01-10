using System.Linq.Expressions;

namespace Berger.Extensions.Abstractions
{
    public interface IRepository<T>
    {
        IQueryable<T> Get(bool tracking = false);
        T GetById(Guid Id);
        IQueryable<T> GetIgnoreFilters();
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        T Add(T source, bool detach = false);
        void Add(IQueryable<T> elements, bool detach = false);
        T Update(T source);
        void Delete(Guid Id);
        void Delete(IQueryable<T> elements);
        Task<T> AddAsync(T source);
        Task<T> UpdateAsync(T source);
        Task UpdateAsync(Func<T, string> field, string value);
        Task DeleteAsync(Guid Id);
    }
}