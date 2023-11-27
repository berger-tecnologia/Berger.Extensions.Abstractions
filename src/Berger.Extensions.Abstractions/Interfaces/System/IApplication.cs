namespace Berger.Extensions.Abstractions
{
    public interface IApplication<T> : IBaseGet<T, List<T>>
    {
        List<T> GetByApplicationCode(string code);
    }
}