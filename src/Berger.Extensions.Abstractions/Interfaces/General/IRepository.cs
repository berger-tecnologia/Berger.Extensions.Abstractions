﻿using System.Linq.Expressions;

namespace Berger.Extensions.Abstractions
{
    public interface IRepository<T> : ICrud<T>
    {
        IQueryable<T> Get();
        T GetById(Guid id);
        IQueryable<T> GetIgnoreFilters();
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        T Add(T element, bool detach = false);
        void Add(IQueryable<T> elements, bool detach = false);
        T Update(T element);
        void Delete(Guid id);
        void Delete(IQueryable<T> elements);
        Task<T> AddAsync(T element);
        Task<T> UpdateAsync(T element);
        Task UpdateAsync(Func<T, string> field, string value);
        Task DeleteAsync(Guid id);
    }
}