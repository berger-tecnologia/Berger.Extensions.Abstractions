namespace Berger.Extensions.Abstractions
{
    public interface IApplicationService<TSource, TDestination> : IPagination<TSource> where TSource : class, IBaseEntity<Guid> where TDestination : IBaseEntity<Guid>
    {
        TSource GetById(Guid id);
        List<TSource> Get();
        TSource Add(TSource source);
        TSource Update(TSource source);
        void Delete(Guid id);
    }
}