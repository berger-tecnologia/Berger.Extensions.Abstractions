namespace Berger.Extensions.Abstractions
{
    public interface IStrapper<T> where T : class
    {
        T Create();
    }
}