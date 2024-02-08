namespace Berger.Extensions.Abstractions
{
    public interface IBaseEntityType<TSource, TDestination> : IBaseApplication<TSource, TDestination> where TSource : BaseEntity where TDestination : BaseEntity
    {
        #region Methods
        List<TSource> GetByEntityTypeId(Guid id);
        #endregion
    }
}