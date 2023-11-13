namespace Berger.Extensions.Abstractions
{
    public interface IService<T>
    {
        IQueryable<T> Get();
        T GetById(Guid id);
    }
}