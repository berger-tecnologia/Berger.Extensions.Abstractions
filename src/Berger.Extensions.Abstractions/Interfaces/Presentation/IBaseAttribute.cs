namespace Berger.Extensions.Abstractions
{
    public interface IBaseAttribute
    {
        #region Properties
        string AttributeId { get; set; }
        #endregion

        #region Methods
        public void SetAttributeId(string attributeId);
        #endregion
    }
}