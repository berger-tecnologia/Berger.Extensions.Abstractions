namespace Berger.Extensions.Abstractions
{
    public interface ITemplate : IBaseEntity<Guid>
    {
        #region Properties
        string Name { get; set; }
        #endregion
    }
}