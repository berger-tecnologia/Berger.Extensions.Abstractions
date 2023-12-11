namespace Berger.Extensions.Abstractions
{
    public interface IBaseApplication<TSource, TDestination> : IPagination<TSource> 
        where TSource : BaseEntity
        where TDestination : BaseEntity
    {
        List<TSource> Get();
        TSource GetById(Guid id);
        TSource Add(TSource source);
        TSource Update(TSource source);
        TSource Manage(TSource source);
        void Delete(Guid Id);
    }
}