namespace Berger.Extensions.Abstractions
{
    public interface IBaseServiceGet<T> : IBaseGet<T, IQueryable<T>>
    {
    }
}