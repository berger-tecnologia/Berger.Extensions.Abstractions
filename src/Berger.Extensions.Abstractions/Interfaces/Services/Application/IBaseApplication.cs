namespace Berger.Extensions.Abstractions
{
    public interface IBaseApplication<TSource, TDestination> : IBaseGet<TSource, List<TSource>>, IPagination<TSource> where TSource : class, IBaseEntity<Guid> where TDestination : IBaseEntity<Guid>
    {
        TSource Add(TSource source);
        TSource Update(TSource source);
        void Delete(Guid Id);
    }
}