namespace Berger.Extensions.Abstractions
{
    public interface IEntityTypeApplication<TSource, TDestination> : IBaseApplication<TSource, TDestination> where TSource : BaseEntity where TDestination : BaseEntity
    {
        #region Methods
        #endregion
    }
}