namespace Berger.Extensions.Abstractions
{
    public interface IApplication<T>
    {
        List<T> GetByApplicationCode(string code);
    }
}