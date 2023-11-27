namespace Berger.Extensions.Abstractions
{
    public interface IApplication<T> : IBaseGet<T, List<T>>, IBaseEntity<Guid>
    {
        List<T> GetByApplicationCode(string code);
    }
}