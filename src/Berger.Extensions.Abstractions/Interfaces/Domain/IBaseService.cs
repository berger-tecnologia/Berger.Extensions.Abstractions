namespace Berger.Extensions.Abstractions
{
    public interface IBaseService<T>
    {
        IQueryable<T> Get();
        T GetById(Guid Id);
    }
}