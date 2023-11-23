namespace Berger.Extensions.Abstractions
{
    public interface IBaseApplication<T>
    {
        List<T> Get();
        T GetById(Guid id);
    }
}