namespace Berger.Extensions.Abstractions
{
    public interface IListApplication<T>
    {
        List<T> Get();
    }
}