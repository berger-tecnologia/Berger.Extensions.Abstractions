namespace Berger.Extensions.Abstractions
{
    public interface IElement<T>
    {
        #region Properties
        Guid? ParentId { get; set; }
        #endregion
    }
}