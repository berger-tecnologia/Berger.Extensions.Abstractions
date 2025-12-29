namespace Berger.Extensions.Abstractions
{
    public interface IHtmlAttribute : IBaseEntity<Guid>
    {
        #region Properties
        string Name { get; set; }
        string AttributeId { get; set; }
        string Href { get; set; }
        string Class { get; set; }
        string Style { get; set; }
        #endregion

        #region Methods
        void SetAttributeId(string attributeId);
        #endregion
    }
}