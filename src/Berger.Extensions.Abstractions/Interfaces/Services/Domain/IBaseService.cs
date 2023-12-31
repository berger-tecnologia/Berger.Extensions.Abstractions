﻿namespace Berger.Extensions.Abstractions
{
    public interface IBaseService<T> 
    {
        IQueryable<T> Get();
		IQueryable<T> Get(IEnumerable<Guid> ids);
		T GetById(Guid id);
        T Add(T source);
        void Add(IQueryable<T> source);
        Task<T> AddAsync(T source);
        T Update(T source);
        Task<T> UpdateAsync(T source);
        Task UpdateAsync(Func<T, string> field, string value);
        void Delete(Guid Id);
        void Delete(IQueryable<T> source);
        Task DeleteAsync(Guid id);
    }
}