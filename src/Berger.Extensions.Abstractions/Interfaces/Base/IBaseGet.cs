namespace Berger.Extensions.Abstractions
{
    public interface IBaseGet<T, TResult>
    {
        TResult Get();
        T GetById(Guid id);
    }
}