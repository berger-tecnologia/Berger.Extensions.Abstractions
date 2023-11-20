namespace Berger.Extensions.Abstractions
{
    public interface IApplication<T> : IListApplication<T>
    {
        List<T> GetByApplication(string applicationCode);
    }
}