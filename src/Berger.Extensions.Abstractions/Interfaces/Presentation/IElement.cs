namespace Berger.Extensions.Abstractions
{
    public interface IElement<T> : IHtmlAttribute where T : Enum
    {
        #region Properties
        Guid? ParentId { get; set; }
        List<IElement<T>> Menus { get; set; }
        string Slug { get; set; }
        string Title { get; set; }
        string Subtitle { get; set; }
        string Description { get; set; }
        int Index { get; set; }
        bool IsModal { get; set; }
        #endregion
    }
}