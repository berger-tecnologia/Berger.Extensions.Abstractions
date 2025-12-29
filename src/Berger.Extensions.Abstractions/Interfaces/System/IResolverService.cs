namespace Berger.Extensions.Abstractions
{
    public interface IResolverService<T>
    {
        #region Methods
        string Resolve(string name);
        List<T> Get();
        T Get(Type type, bool mandatory = true);
        #endregion
    }
}