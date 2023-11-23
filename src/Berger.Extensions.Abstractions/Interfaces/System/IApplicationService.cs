namespace Berger.Extensions.Abstractions
{
    public interface IApplicationBaseService<TSource, TDestination> : IPagination<TSource> where TSource : class, IBaseEntity<Guid> where TDestination : IBaseEntity<Guid>
    {
        TSource GetById(Guid Id);
        List<TSource> Get();
        TSource Add(TSource source);
        TSource Update(TSource source);
        void Delete(Guid Id);
    }
}