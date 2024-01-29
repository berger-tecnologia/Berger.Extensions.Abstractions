namespace Berger.Extensions.Abstractions
{
    public interface IAttributeValued
    {
        #region Properties
        List<IAttributeValue> AttributeValues { get; set; }
        #endregion
    }
}