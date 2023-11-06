namespace Berger.Extensions.Abstractions
{
    public interface IDynamic<T> where T : class
    {
        T Create();
    }
}