namespace Berger.Extensions.Abstractions
{
    public interface IElement
    {
        #region Properties
        Guid? ParentId { get; set; }
        Guid? ColorId { get; set; }
        string Name { get; set; }
        string Slug { get; set; }
        string Href { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        int Order { get; set; }
        bool IsModal { get; set; }
        string AttributeId { get; set; }
        #endregion
    }
}