namespace Berger.Extensions.Abstractions
{
    public interface IEntityTypeService<T> : IBaseService<T>
    {
        IQueryable<T> GetByEntityTypeId(Guid id);
    }
}